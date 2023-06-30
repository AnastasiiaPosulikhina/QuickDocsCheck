namespace AmbiguosSymbols
{
    public class Test
    {
        
    }
    
    /// <summary>
    ///     A
    /// </summary>
    class A
    {
        
    }

    /// <summary>
    ///     B
    /// </summary>
    class B : A
    {
        
    }

    /// <summary>
    ///     C
    /// </summary>
    class C : B
    {
        
    }

    /// <summary>
    ///     D
    /// </summary>
    class D : C
    {
        
    }
}