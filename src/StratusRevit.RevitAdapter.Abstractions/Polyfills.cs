// Polyfill so that 'record' and 'init' compile on netstandard2.0 / net48
#if !NET5_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}
#endif
