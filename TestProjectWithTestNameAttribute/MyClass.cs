using System;
using System.Collections.Generic;

namespace TestProjectWithTestNameAttribute
{
    class A: Attribute
    {
        public A(Type t) {}
    }
    
    public class MyClass
    {
        [A(typeof(List<int>))] 
        private int _x;

        private int _y;

        
        void Method()
        {
            _x = 5;
            Console.WriteLine(_x);
        }
    }
}