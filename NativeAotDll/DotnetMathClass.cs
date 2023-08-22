using System.Runtime.InteropServices;

namespace NativeAotDll
{
    public unsafe class DotnetMathClass
    {
        [UnmanagedCallersOnly(EntryPoint = "Add")]
        public static int Add(int i, int j)
        {
            return i + j;
        }
    }
}