namespace Enum;

public class Test
{
    
}

enum TestEnum
{
    One = 1,
    Two,
    Three = One & Two,
    Four = One | Two,
    Five = ~Four,
    Six = Four >> One & Two | Three 
}

enum TestEnum2
{
    One = 1,
    Two = 0xFFAA,
    Three = One & Two,
    Four = 4 >> 2,
    Five = 2 << 4,
    Six = ~Three,
}