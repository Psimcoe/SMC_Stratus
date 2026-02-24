<#
.SYNOPSIS
    Builds and deploys the StratusRevit addin to the Revit 2023 Addins folder.

.DESCRIPTION
    1. Builds StratusRevit.Addin.Revit2023 in Release configuration
    2. Copies the .addin manifest to %AppData%\Autodesk\Revit\Addins\2023\
    3. Copies all output DLLs to %AppData%\Autodesk\Revit\Addins\2023\StratusRevit\
    4. Copies config files (stratus-addin.json, mapping.json) if not already present

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
$repoRoot     = Split-Path -Parent $PSScriptRoot   # script lives in scripts/, repo is one level up
$projectDir   = Join-Path $repoRoot "src\StratusRevit.Addin.Revit2023"
$distDir      = Join-Path $repoRoot "dist\Revit2023"
$buildOutput  = Join-Path $projectDir "bin\$Configuration\net48"

$revitAddins   = Join-Path $env:APPDATA "Autodesk\Revit\Addins\2023"
$deployFolder  = Join-Path $revitAddins "StratusRevit"

# --- Preflight checks ---
if (-not (Test-Path $projectDir)) {
    Write-Error "Project not found at $projectDir. Run from the repo root or scripts folder."
    exit 1
}

if (-not (Test-Path $revitAddins)) {
    Write-Host "Creating Revit 2023 Addins directory: $revitAddins" -ForegroundColor Yellow
    New-Item -ItemType Directory -Path $revitAddins -Force | Out-Null
}

# --- Step 1: Build ---
Write-Host "`n=== Building StratusRevit.Addin.Revit2023 ($Configuration) ===" -ForegroundColor Cyan
dotnet build $projectDir -c $Configuration --nologo
if ($LASTEXITCODE -ne 0) {
    Write-Error "Build failed. Fix errors above and retry."
    exit 1
}
Write-Host "Build succeeded." -ForegroundColor Green

# --- Step 2: Copy .addin manifest ---
Write-Host "`n=== Deploying .addin manifest ===" -ForegroundColor Cyan
$addinManifest = Join-Path $distDir "StratusRevit.addin"
if (-not (Test-Path $addinManifest)) {
    Write-Error ".addin manifest not found: $addinManifest"
    exit 1
}
Copy-Item $addinManifest -Destination $revitAddins -Force
Write-Host "  -> $revitAddins\StratusRevit.addin" -ForegroundColor Gray

# --- Step 3: Copy DLLs ---
Write-Host "`n=== Deploying DLLs to $deployFolder ===" -ForegroundColor Cyan
if (-not (Test-Path $deployFolder)) {
    New-Item -ItemType Directory -Path $deployFolder -Force | Out-Null
}

$files = Get-ChildItem -Path $buildOutput -File
$count = 0
foreach ($file in $files) {
    Copy-Item $file.FullName -Destination $deployFolder -Force
    $count++
}
Write-Host "  Copied $count files." -ForegroundColor Gray

# --- Step 4: Copy config files (only if missing) ---
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
Write-Host "DLLs     : $deployFolder"
Write-Host "Config   : $deployFolder\stratus-addin.json"
Write-Host "Mapping  : $deployFolder\mapping.json"
Write-Host "`nNext steps:" -ForegroundColor Cyan
Write-Host "  1. Edit $deployFolder\stratus-addin.json and set your API key"
Write-Host "  2. Edit $deployFolder\mapping.json with your Revit parameter names"
Write-Host "  3. Launch Revit 2023 -> Add-Ins tab -> Stratus Dry Run / Push Updates"
