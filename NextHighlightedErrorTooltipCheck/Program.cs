using System;

namespace NextHighlightedErrorTooltipCheck
{
      // https://youtrack.jetbrains.com/issue/RIDER-57978
      #nullable enable
      public class Program
      {
            public interface Interface1<T> where T: LongClassNameThatShouldBeShown
            {
            }

            public class LongClassNameThatShouldBeShown
            {
            }

                  public class Class1: Interface1<string>
                  {
                  }

            Main()
            {
                  Console.WriteLine("Hello World!")
            }

      }
}