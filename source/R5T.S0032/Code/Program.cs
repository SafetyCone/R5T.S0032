using System;
using System.Threading.Tasks;

using R5T.N0001.Generation.Initial.Simple;


namespace R5T.S0032
{
    class Program
    {
        static Task Main()
        {
            //Program.WriteSpace();
            Program.WriteInterface();

            return Task.CompletedTask;
        }

#pragma warning disable IDE0051 // Remove unused private members

        static void WriteInterface()
        {
            var interfaceTypeName = "ISolutionFileSetContextProvider";

            var @interface = Instances.SyntaxGenerator.Interface(interfaceTypeName);

            @interface.WriteToExampleCodeFilePath();
        }

        /// <summary>
        /// Writes a space to a code file.
        /// This is a first hello-world level program to test out this methodology for creating functionality.
        /// </summary>
        static void WriteSpace()
        {
            var space = Instances.SyntaxGenerator.Space();

            space.WriteToExampleCodeFilePath();
        }
    }
}