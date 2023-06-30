using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ChecksSyntaxHighlightingInAttributes
{
    public class Program
    {
        public static string Value;
        public static List<string> Values;

        public static void Main(string[] args)
        {
            Console.WriteLine();
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine();
                    }

                    public static IHostBuilder CreateHostBuilder(string[] args)
                    {
                        return Host.CreateDefaultBuilder(args)
                            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
                    }
                }

    [DefaultProperty("StringPropertyName")]
    [DefaultValue(true)]
    [Obsolete("StringMessage", true, DiagnosticId = "ID")]
    internal class Test1
    {
    }

    internal class Test2
    {
        [Conditional("DEBUG")]
        [Conditional("TEST1")]
        private void TraceMethod()
        {
            // ...
            Console.WriteLine();
        }
    }
}