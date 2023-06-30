using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AmbiguosSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 8;
            var c = b / a;
            Console.WriteLine("Hello World!" + c);
            Console.WriteLine();
            
            
            var list1 = new List<int>();
            var list2 = new List<int>();
            list1.SequenceEqual();

            var dataTable = new DataTable();

            foreach (DataRow row in dataTable.Rows)
            {
                for (var i = 0; i < dataTable.Columns.Count; i++)
                {
                    var column = dataTable.Columns[i];
                    switch (column.DataType.ToString())
                    {
                        case "System.String":
                            var strVal = row.Field(i).Trim();
                            break;
                        case "System.Int32":
                            var intVal = row.Field(i);
                    }
                }
            }

        }
    }
}