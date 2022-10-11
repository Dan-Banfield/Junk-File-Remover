using System;
using System.IO;
using System.Threading.Tasks;

namespace Junk_File_Remover.Core
{
    internal static class Deletion
    {
        internal static async Task DeleteAppData()
        {
            await Task.Run(() 
                => DeleteFilesInDirectory(@"C:\Users\" + 
                Environment.UserName + @"\AppData\Local\Temp"));
        }

        internal static async Task DeleteUpdateFiles()
        {
            await Task.Run(()
                => DeleteFilesInDirectory(@"C:\Windows\SoftwareDistribution"));
        }

        internal static async Task DeleteTemporaryWindowsFiles()
        {
            await Task.Run(()
                => DeleteFilesInDirectory(@"C:\Windows\Temp"));
        }

        private static void DeleteFilesInDirectory(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                try { File.Delete(file); }
                catch { continue; }
            }
        }
    }
}