using System;
using System.IO;
using System.Reflection;

namespace AssemblyLoadExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string assemblyPath = Path.GetFullPath(
                Path.Combine(
                    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "..", "..", "..", "AssemblyToBeLoaded", "bin", "Debug",
                    "AssemblyToBeLoaded.dll"));

            var assembly = Assembly.LoadFile(assemblyPath);
            dynamic compiler = assembly.CreateInstance("AssemblyToBeLoaded.Compiler");
            try
            {
                // compiler.GetType().GetMethod("Compile").Invoke(compiler, Type.EmptyTypes);
                compiler.Compile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}