using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lession1_HelloWorld
{

    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        static void Main(string[] args)
        {



            //Process p = Process.GetCurrentProcess();
            //ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3

            // Starting from Console.WriteLine and Console.Write
            //Console.WriteLine("Hello World");


            Console.Write("W");
            Console.Write("O");
            Console.Write("R");
            Console.Write("L");
            Console.Write("D");
            Console.WriteLine(); // Empty Line

            //Console.ReadLine();
            //Console.Clear();


            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Hello World");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.WriteLine("Hello World Again");


            //Console.ResetColor();            
            //Console.WriteLine("{0}", Console.WindowWidth);
            //Console.WriteLine("{0}", Console.WindowHeight);

            //Console.WriteLine("Window Width: {0}  Window Height: {1}", Console.WindowWidth, Console.WindowHeight);

            //Console.WriteLine($"LargestWindowWidth {Console.LargestWindowWidth}");
            //Console.WriteLine($"LargestWindowHeight {Console.LargestWindowHeight}");
            //Console.WriteLine($" result {1 + 1}");

            //Console.WriteLine("Hello " + "World" + Console.LargestWindowWidth);


            //Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
            //Console.WriteLine("A");


            //Console.WriteLine("Please enter something:");
            //string s = Console.ReadLine();
            //Console.WriteLine("You hit {0}", s);


            //Console.WriteLine("Press escape to exit");
            //ConsoleKeyInfo c = Console.ReadKey();
            //while (c.Key != ConsoleKey.Escape)
            //{
            //    c = Console.ReadKey();
            //}

            //Console.WriteLine("Exit !!!");
            //return;


            // how to update the current line = \r move the cursor to the start or the line

            //for (int i = 0; i < 1000000; ++i)
            //{
            //    Console.Write("\r{0}%   ", i);
            //}


            Console.CursorVisible = false;
            //Console.CapsLock;  only get
            //Console.WriteLine($"Caps lock state is: {Console.CapsLock}");


            //Console.CursorLeft += 20;
            //Console.WriteLine("Hello");


            //Console.BufferHeight = 80;

            /*
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.ReadLine(); 
            Console.MoveBufferArea(0, 0, 5, 3, 1, 0);
            */

            // Advanced Example
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            Console.WriteLine("*****");
            for (int i = 0; i < 40; i++)
            {
                Console.MoveBufferArea(i, 0, 5, 3, i + 1, 0);
                Thread.Sleep(100);
            }

            //Console.MoveBufferArea(0, 0, Console.BufferWidth, Console.BufferHeight, 20, 20);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
              
        }
    }
}
