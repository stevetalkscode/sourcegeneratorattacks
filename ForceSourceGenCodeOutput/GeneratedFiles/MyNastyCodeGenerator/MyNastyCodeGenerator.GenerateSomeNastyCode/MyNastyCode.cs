using System;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[GeneratedCode("GenerateSomeNastyCode", "1.0.0.0")]
public static class IAmANastyBitOfCode
{
    [CompilerGenerated]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ModuleInitializer]
    public static void PrintHostNameToDebugger()
    {        
        Debug.Print("I could have done something nasty here");
    }
}
