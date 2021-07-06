using System;
using System.ComponentModel.DataAnnotations;

namespace d
{
      /// <summary>
      /// This is a summary
      /// </summary>
      [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
      public sealed class ParameterAliasAttribute : Attribute
      {

            public ParameterAliasAttribute(String alias)
            {
                  Alias = alias;
            }

            public string Alias { get; set; }

      }
      
      /// <summary>
      /// You may have some primary information about this interface.
      /// </summary>
      public interface ITestInterface
      {
      }

      ///<inheritdoc cref="ITestInterface"/>
      public class TestClass : ITestInterface
      {
      }
      
      public class InheritAllButRemarks
      {
            /// <summary>In this example, this summary is visible on all the methods.</summary>
            /// <remarks>The remarks.</remarks>
            /// <returns>A boolean</returns>
            public static bool MyParentMethod(bool x) { return x; }
    
            /// <param name="bar"></param>
            public static bool MyChildMethod(string bar) { return false; }
      }

      public class MyClass
      {

            public static String NamelessParameterAlias { get; set; }
            
            /// <summary>Summary.</summary>
            /// <param name="bar1">The first argument is a <see cref="Int32"/> to pass to FOO.</param>
            /// <param name="bar2">The second argument is a <see cref="Int64"/> to pass to FOO.</param>
            /// 
            private static void Foo(Int32 bar1, Int64 bar2) 
            {
                  Console.WriteLine(bar1);
                  Console.WriteLine(bar2);
            }
            
            /// <param name="bar">The first argument is a "Int32" to pass to <code>FOO</code>.</param>
            private static void Foo2(string bar) 
            {
                  Console.WriteLine(bar);
            }
            
            /// <param name="bar">
            /// </param>
            private static void Foo3(string bar) 
            {
                  Console.WriteLine(bar);
            }
            
            private static void Foo4(string bar) 
            {
                  Console.WriteLine(bar);
            }
            
           
            /// <summary>
            /// My attribute
            /// </summary>
            ///[ParameterAlias(NamelessParameterAlias), Required] 
            private String MyField;

            public MyClass(string myField)
            {
                  MyField = myField;
            }

      }
}