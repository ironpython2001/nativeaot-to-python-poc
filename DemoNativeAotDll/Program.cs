// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

[DllImport("NativeAotDll.dll")]
static extern int Add(int i, int j);


int i = Add(1, 2);
Console.WriteLine(i);