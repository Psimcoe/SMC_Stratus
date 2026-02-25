<#
.SYNOPSIS
    Builds and deploys the StratusRevit addin + PushAgent to the Revit 2023 Addins folder.

.DESCRIPTION
    1. Builds StratusRevit.Addin.Revit2023 (net48) – lightweight Revit addin, no HTTP
    2. Builds StratusRevit.PushAgent (net8.0) – out-of-process agent that calls Stratus API
    3. Copies .addin manifest to %AppData%\Autodesk\Revit\Addins\2023\
    4. Copies addin DLLs to …\StratusRevit\
    5. Copies agent output to …\StratusRevit\agent\
    6. Copies config files if not already present

.PARAMETER Configuration
    Build configuration. Default: Release

.EXAMPLE
    .\Deploy-Revit2023.ps1
    .\Deploy-Revit2023.ps1 -Configuration Debug
#>

param(
    [string]$Configuration = "Release"
)

$ErrorActionPreference = "Stop"

# --- Paths ---
$repoRoot       = Split-Path -Parent $PSScriptRoot
$addinProject   = Join-Path $repoRoot "src\StratusRevit.Addin.Revit2023"
$agentProject   = Join-Path $repoRoot "src\StratusRevit.PushAgent"
$distDir        = Join-Path $repoRoot "dist\Revit2023"
$addinOutput    = Join-Path $addinProject "bin\$Configuration\net48"
$agentOutput    = Join-Path $agentProject "bin\$Configuration\net8.0"

$revitAddins    = Join-Path $env:APPDATA "Autodesk\Revit\Addins\2023"
$deployFolder   = Join-Path $revitAddins "StratusRevit"
$agentDeploy    = Join-Path $deployFolder "agent"

# --- Preflight ---
if (-not (Test-Path $addinProject)) {
    Write-Error "Addin project not found at $addinProject"
    exit 1
}
if (-not (Test-Path $revitAddins)) {
    New-Item -ItemType Directory -Path $revitAddins -Force | Out-Null
}

# --- Step 1: Build Revit addin (net48, lightweight) ---
Write-Host "`n=== Building Revit Addin (net48) ===" -ForegroundColor Cyan
dotnet build $addinProject -c $Configuration --nologo
if ($LASTEXITCODE -ne 0) { Write-Error "Addin build failed."; exit 1 }
Write-Host "Addin build succeeded." -ForegroundColor Green

# --- Step 2: Build PushAgent (net8.0, self-contained HTTP) ---
Write-Host "`n=== Building PushAgent (net8.0) ===" -ForegroundColor Cyan
dotnet build $agentProject -c $Configuration --nologo
if ($LASTEXITCODE -ne 0) { Write-Error "PushAgent build failed."; exit 1 }
Write-Host "PushAgent build succeeded." -ForegroundColor Green

# --- Step 3: Copy .addin manifest ---
Write-Host "`n=== Deploying .addin manifest ===" -ForegroundColor Cyan
$addinManifest = Join-Path $distDir "StratusRevit.addin"
if (-not (Test-Path $addinManifest)) {
    Write-Error ".addin manifest not found: $addinManifest"
    exit 1
}
Copy-Item $addinManifest -Destination $revitAddins -Force
Write-Host "  -> $revitAddins\StratusRevit.addin" -ForegroundColor Gray

# --- Step 4: Copy addin DLLs (slim – no HTTP assemblies) ---
Write-Host "`n=== Deploying addin DLLs ===" -ForegroundColor Cyan
if (-not (Test-Path $deployFolder)) { New-Item -ItemType Directory -Path $deployFolder -Force | Out-Null }

$addinFiles = Get-ChildItem -Path $addinOutput -File
$count = 0
foreach ($f in $addinFiles) {
    Copy-Item $f.FullName -Destination $deployFolder -Force
    $count++
}
Write-Host "  Copied $count addin files." -ForegroundColor Gray

# --- Step 5: Copy PushAgent output ---
Write-Host "`n=== Deploying PushAgent to agent\ subfolder ===" -ForegroundColor Cyan
if (-not (Test-Path $agentDeploy)) { New-Item -ItemType Directory -Path $agentDeploy -Force | Out-Null }

$agentFiles = Get-ChildItem -Path $agentOutput -File
$aCount = 0
foreach ($f in $agentFiles) {
    Copy-Item $f.FullName -Destination $agentDeploy -Force
    $aCount++
}
Write-Host "  Copied $aCount agent files." -ForegroundColor Gray

# --- Step 6: Config files (only if missing) ---
Write-Host "`n=== Config files ===" -ForegroundColor Cyan

$configSource = Join-Path $distDir "stratus-addin.json"
$configDest   = Join-Path $deployFolder "stratus-addin.json"
if (-not (Test-Path $configDest)) {
    if (Test-Path $configSource) {
        Copy-Item $configSource -Destination $configDest
        Write-Host "  Created stratus-addin.json (edit apiKey before use)" -ForegroundColor Yellow
    }
} else {
    Write-Host "  stratus-addin.json already exists, skipping." -ForegroundColor Gray
}

$mappingSource = Join-Path $repoRoot "config\examples\mapping.sample.json"
$mappingDest   = Join-Path $deployFolder "mapping.json"
if (-not (Test-Path $mappingDest)) {
    if (Test-Path $mappingSource) {
        Copy-Item $mappingSource -Destination $mappingDest
        Write-Host "  Created mapping.json from sample (customise field mappings)" -ForegroundColor Yellow
    }
} else {
    Write-Host "  mapping.json already exists, skipping." -ForegroundColor Gray
}

# --- Done ---
Write-Host "`n=== Deployment complete ===" -ForegroundColor Green
Write-Host "Manifest : $revitAddins\StratusRevit.addin"
Write-Host "Addin    : $deployFolder  ($count files)"
Write-Host "Agent    : $agentDeploy  ($aCount files)"
Write-Host "Config   : $deployFolder\stratus-addin.json"
Write-Host "Mapping  : $deployFolder\mapping.json"
Write-Host "`nArchitecture:" -ForegroundColor Cyan
Write-Host "  Revit addin (net48) -> extracts data, writes JSON payload"
Write-Host "  PushAgent (net8.0)  -> reads payload, calls Stratus API, writes result"
Write-Host "  No HTTP calls inside the Revit process = no assembly conflicts"
