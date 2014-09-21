.namespace MyFirstProgram
{
  .class private auto ansi beforefieldinit MainClass
  	extends [mscorlib]System.Object
  {

    // method line 1
    .method public hidebysig  specialname  rtspecialname 
           instance default void '.ctor' ()  cil managed 
    {
        // Method begins at RVA 0x20ec
	// Code size 7 (0x7)
	.maxstack 8
	IL_0000:  ldarg.0 
	IL_0001:  call instance void object::'.ctor'()
	IL_0006:  ret 
    } // end of method MainClass::.ctor

    // method line 2
    .method public static  hidebysig 
           default void Main (string[] args)  cil managed 
    {
        // Method begins at RVA 0x20f4
	.entrypoint
	// Code size 11 (0xb)
	.maxstack 8
	IL_0000:  ldstr "Hello, world!"
	IL_0005:  call void class [mscorlib]System.Console::WriteLine(string)
	IL_000a:  ret 
    } // end of method MainClass::Main

  } // end of class MyFirstProgram.MainClass
}
