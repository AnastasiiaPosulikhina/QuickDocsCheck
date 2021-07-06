using System;
using System.Collections.Generic;
using System.Data;

namespace KeyValuePairsInQuickDocs
{
    class Program
    {
        // mestake
        // correctly written comment
        // camment weth typos
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dataTable = new DataTable();

            Tuple<int, string, List<int>, Account<uint>> tuple2 = new Tuple<int, string, List<int>, Account<uint>>(5, "value", new List<int>(), new Account<uint>());
            Tuple<string, List<int>> tuple = new Tuple<string, List<int>>("string", new List<int>());
            
            Account<int> account1 = new Account<int> { Sum = 5000 };
            account1.Id = 2;      
            uint num;
            int id1 = account1.Id;  
            Console.WriteLine(id1);
            
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();
            string s;
            sortedDictionary.TryGetValue("", out s);
            
            Dictionary<Dictionary<string, string>.KeyCollection, Dictionary<int, Account<int>>.ValueCollection> dictionary 
                = new Dictionary<Dictionary<string, string>.KeyCollection, Dictionary<int, Account<int>>.ValueCollection>();

            var x = new KeyValuePair<int, string>();
            var y = x.Key;
            var z = x.Value;

            int a;

        }
    }

    internal class Account<T>
    {
        public T Id { get; set; }
        public int Sum { get; set; }
    }
}