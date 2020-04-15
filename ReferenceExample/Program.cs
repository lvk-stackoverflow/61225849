using System;

using AssemblyToBeLoaded;

namespace ReferenceExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var compiler = new Compiler();
            try
            {
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