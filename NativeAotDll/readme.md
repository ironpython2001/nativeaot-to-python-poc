steps to compile

1. publish the NativeAotDll project at command line

   dotnet publish -r win-x64 -c Release
2. Inside \bin\Release\net7.0\win-x64\publish\ you should find the *.dll file.

3. To use in dotnet project 
	a. copy the dll to "DemoNativeAotDll\bin\Debug\net7.0\" 
	b. run the demonativeaotdll project

4. To use in python project 
	a. copy the dll to "PythonDemoNativeAotDll\"
	b. run the PythonDemoNativeAotDll python file

references:

https://joeysenna.com/posts/nativeaot-in-c-plus-plus

https://github.com/Joey0x646576/nativeaot-to-cplusplus-example/blob/main/NativeAot/NativeDll/Library.cs

https://stackoverflow.com/questions/75419409/how-to-use-a-dll-generated-in-c-sharp-and-compiled-using-native-aot-in-other-ne

https://github.com/dotnet/samples/blob/main/core/nativeaot/HelloWorld/README.md

https://github.com/dotnet/samples/blob/main/core/nativeaot/NativeLibrary/README.md

https://mazeez.dev/posts/writing-native-libraries-in-csharp

https://betterprogramming.pub/how-to-create-a-python-wrapper-for-c-c-shared-libraries-35ffefcfc10b

https://realpython.com/python-bindings-overview/