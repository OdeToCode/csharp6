using System;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using Microsoft.CodeAnalysis;
using System.Reflection;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            var code = File.ReadAllText("code.cs");
            var tree = SyntaxFactory.ParseSyntaxTree(code);
            var compilation = CSharpCompilation.Create("test", options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
                                               .AddSyntaxTrees(tree)
                                               .AddReferences(new MetadataFileReference(typeof(object).Assembly.Location));
            var model = compilation.GetSemanticModel(tree);

            var diag = compilation.GetDiagnostics();
            foreach (var diagnostic in diag)
            {
                Console.WriteLine(diagnostic.GetMessage());
            }

            using (var stream = new MemoryStream())
            {
                compilation.Emit(stream);
                var assembly = Assembly.Load(stream.GetBuffer());
                var type = assembly.GetType("Greeter");
                var greeter = Activator.CreateInstance(type);
                var method = type.GetMethod("SayHello");
                method.Invoke(greeter, null);
            }

            DumpLocals(tree, model);
        }

        private static void DumpLocals(SyntaxTree tree, SemanticModel model)
        {
            var locals = tree.GetRoot().DescendantNodes().OfType<LocalDeclarationStatementSyntax>();
            foreach (var local in locals)
            {
                var type = model.GetTypeInfo(local.Declaration.Type);
                Console.WriteLine("{0} {1}", type.Type, local.Declaration);
            }
        }
    }
}
