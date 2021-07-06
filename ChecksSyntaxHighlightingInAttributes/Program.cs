using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ChecksSyntaxHighlightingInAttributes
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
    
    [DefaultProperty("StringPropertyName")]
    [DefaultValue(true)]
    [Obsolete("StringMessage", true, DiagnosticId = "ID")]
    internal class Test1
    {
        
    }

    class Test2
    {
        [Conditional("DEBUG"), Conditional("TEST1")]
        void TraceMethod()
        {
            // ...
            Console.WriteLine();
        }
    }
}