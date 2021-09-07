using System;
using System.Collections.Generic;
using System.ComponentModel;

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

        
        void Method([A(typeof(int))] int value)
        {
            _x = 5;
            Console.WriteLine(_x);
            Method(3);
        }
    }
}