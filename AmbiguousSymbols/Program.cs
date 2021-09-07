using System;
using System.Data;

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
            
            var dataTable = new DataTable();
            Attribute a;

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