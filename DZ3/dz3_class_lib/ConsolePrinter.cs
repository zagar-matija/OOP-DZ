using System;
using System.Collections.Generic;
using System.Text;

namespace dz3_class_lib
{
    public class ConsolePrinter : IPrinter
    {
        ConsoleColor color;
        public ConsolePrinter(ConsoleColor color)
        {
            this.color = color;
        }
        public void Log(string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void SetConsoleColor(ConsoleColor color)
        {
            this.color = color;
        }
    }
}
