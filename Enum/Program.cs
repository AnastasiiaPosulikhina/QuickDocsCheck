// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Foo f = new Foo(); 

Console.WriteLine(f.ToString());

Console.WriteLine(1.ToString());
Console.WriteLine(2.ToString());

class Foo
{
    public override string ToString()
    {
        return "I'm Foo";
    }
}