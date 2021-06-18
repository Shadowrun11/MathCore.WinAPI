using System;
using System.Diagnostics;
using System.Threading;
using MathCore.WinAPI.Windows;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var notepad_process = Process.Start("notepad");

            Console.WriteLine("Ждем...");
            Console.ReadLine();

            //var notepad = Window.Find(w => w.Text.EndsWith("Notepad++"));
            //foreach (var w in notepad)
            //    w.Text = "QWE";

            var main_windows_hWnd = notepad_process.MainWindowHandle;

            Window window = new Window(main_windows_hWnd);

            Console.WriteLine("Текст окна = {0}", window.Text);
            Console.WriteLine("Координаты окна = {0}", window.Rectangle);

            // window.Text = "Hello world!";

            //for(var x= window.X; x < 1692; x += 10)
            //{
            //    window.X = x;
            //    Thread.Sleep(100);
            //}

            //Console.ReadLine();
            //Console.WriteLine("Закрыть!");
            //window.Close();

            Console.WriteLine("Поверх всех окон.");
            window.SetTopMost();
            Console.ReadLine();

            Console.WriteLine("НЕ Поверх всех окон.");
            window.SetTopMost(false);
            Console.ReadLine();

            Console.WriteLine("Завершено.");
            Console.ReadLine();

            notepad_process.CloseMainWindow();
        }
    }
}
