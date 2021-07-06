using System;

namespace ClassLibraryCore
{
    public class Class1
    {
    }
    
    /// <summary>
    /// This is an example class. It contains no references to <code>System.StringBuilder</code>
    /// <exception cref="System.NullReferenceException">NPE</exception>
    /// </summary>
    /// <typeparam name="T">Ghost type</typeparam>
    class Program<T>
    {
        public static void Main()
        {
            new Program<string>().Foo(0);
        }

        /**
         * This is a doc comment that starts with /**.
         * <param name="x">The super important value!</param>
         */
        private void Foo(int x)
        {
            Console.WriteLine(x);
        }
        
        public static void AA()
        {
        }

        // hovering over the "bb"  property also leads to stopping on the breakpoint in the BB method
        private static int bb => BB();
        
        public static int BB()
        {
            return 1;
        }
    }
}