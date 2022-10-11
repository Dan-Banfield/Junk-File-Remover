using System;
using Junk_File_Remover.Core;

namespace Junk_File_Remover
{
    internal class Program
    {
        static void Main()
        {
            SetUpConsole();
            DeleteJunkFiles();
        }

        private static void SetUpConsole()
        {
            Console.Title = "Junk File Remover";
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void DeleteJunkFiles()
        {
            ConsoleExtensions.WriteLine("Removing temporary app data...\n", 
                ConsoleExtensions.LINE_TYPE.INFO);
            Deletion.DeleteAppData().Wait();

            ConsoleExtensions.WriteLine("Removing Windows update files...\n",
                ConsoleExtensions.LINE_TYPE.INFO);
            Deletion.DeleteUpdateFiles().Wait();

            ConsoleExtensions.WriteLine("Removing temporary Windows files...\n\n",
                ConsoleExtensions.LINE_TYPE.INFO);
            Deletion.DeleteTemporaryWindowsFiles().Wait();

            ConsoleExtensions.WriteLine("Done! Press any key to exit.",
                ConsoleExtensions.LINE_TYPE.INFO);

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}