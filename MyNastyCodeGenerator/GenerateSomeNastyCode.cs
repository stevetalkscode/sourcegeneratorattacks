using Microsoft.CodeAnalysis;

namespace MyNastyCodeGenerator
{
    [Generator]
    public class GenerateSomeNastyCode : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {            
        }
        public void Execute(GeneratorExecutionContext context)
        {
            var genName = GetType().Name;
            var version = GetType().Assembly.GetName().Version.ToString();

            var text = @"using System;
using System.ComponentModel;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[GeneratedCode("""
+ genName 
+ @""", """
+ version
+ @""")]
"
+ @"public static class IAmANastyBitOfCode
{
    [CompilerGenerated]
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ModuleInitializer]
    public static void PrintHostNameToDebugger()
    {        
        Debug.Print(""I could have done something nasty here"");
    }
}
";            
            context.AddSource("MyNastyCode.cs", text);
        }
    }
}
