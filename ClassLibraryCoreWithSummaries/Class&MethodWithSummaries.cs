using System;
using System.Collections.Generic;

namespace ClassLibraryCore
{
    public class Class1
    {
    }
    
    public class Test
    {
        /// <summary>42</summary>
        private const int MeaningOfLife = 42;
    
        /// <summary>
        /// The answer to life, universe and everything (<inheritdoc cref="MeaningOfLife"/>)
        /// </summary>
        public int Answer { get; }
    
        /// <summary>
        /// Test comment
        /// </summary>
        public void Test2(int test)
        {
        }
        
        public static void Method2(string[] args)
        {
            int number;
            Method1(new Element(), out number);
        }
        public static List<int> Method1(Element element, out int number)
        {
            number = 0;
            return new List<int>();
        }
    }

    public class Element
    {
        /// <summary>
        /// Gets the first row whose specified column matches <see cref="columnValue"/>
        /// </summary>
        /// <param name="columnIndex">Zero-based index of the column to search</param>
        /// <param name="columnValue">Value to search</param>
        public string GetRowByColumnValue(int columnIndex, string columnValue)
        {
            return String.Empty;
        }

        /// <inheritdoc cref="GetRowByColumnValue(int,string)"/>
        /// <param name="columnHeader">The header of the column to search</param>
        public string GetRowByColumnValue(string columnHeader, string columnValue)
        {
            return String.Empty;
        }
    }



    /// <summary>
    /// This is an example class. It contains no references to <code>System.StringBuilder</code>
    /// <exception cref="System.NullReferenceException">NPE</exception>
    /// </summary>
    /// <typeparam name="Ty">Ghost type</typeparam>
    class Program<TypeT>
    {
        /// <summary>
        /// This is a table:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Column A</term>
        ///     <term>Column B</term>
        ///     <term>Column C</term>
        ///   </listheader>
        ///   <item>
        ///     <term>Foo</term>
        ///     <term>Bar</term>
        ///     <term>Baz</term>
        ///   </item>
        ///   <item>
        ///     <term>Hello</term>
        ///     <term>Beautiful</term>
        ///     <term>World</term>
        ///   </item>
        /// </list>
        /// </summary>
        public void SomeMethod() { }
        public static void Main()
        {
            new Program<string>().Foo(1, 0);
        }

        /**
         * This is a doc comment that starts with /**.
         * <param name="x">The super important value!</param>
         */
        private void Foo(int x, int y)
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