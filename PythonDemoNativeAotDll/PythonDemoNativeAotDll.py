
import ctypes
import pathlib

if __name__ == "__main__":
    # Load the shared library into ctypes
    libname = "NativeAotDll.dll"
    c_lib = ctypes.CDLL(libname)
    i = c_lib.Add(1,2)
    print(i);