using System;

namespace Junk_File_Remover.Core
{
    internal static class ConsoleExtensions
    {
        internal enum LINE_TYPE
        {
            INFO,
            ERROR,
            WARNING,
            INPUT
        }

        internal static void WriteLine(string content, LINE_TYPE lineType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");

            switch (lineType)
            {
                case LINE_TYPE.INFO:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("INFO");
                    break;
                case LINE_TYPE.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR");
                    break;
                case LINE_TYPE.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("WARNING");
                    break;
                case LINE_TYPE.INPUT:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("INPUT");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            Console.Write(content);
        }
    }
}