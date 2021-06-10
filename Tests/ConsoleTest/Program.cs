using System;
using System.Diagnostics;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var notepad = Process.Start("notepad");
            Console.WriteLine("Завершено.");
            Console.ReadLine();

            notepad.CloseMainWindow();
        }
    }
}
