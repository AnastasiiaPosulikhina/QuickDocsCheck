using System;
using System.Collections.Generic;

namespace ArgumentsOnWrongLineInQuickDocs
{
    static class Program
    {
        // mestake
        // correctly written comment
        // camment weth typos
        // newly aded comment
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Hello World!");
            Method(new Element(), out number);
        }



        public static List<int> Method(
            this Element element, 
            out int number, 
            string s = "some default value",
            params object[] list)
        {
            number = 0;
            return new List<int>();
        }
    }

    internal class Element
    {
    }

    internal class Instruction
    {
    }
}