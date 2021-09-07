namespace ClassLibraryClassic
{
    // mestake
    // correctly written comment
    // camment weth typos
    // newly aded comment
    public class VarForDeconstruction
    {
        public (string, int, double, int) person = ("Tom", 25, 81.23, 5);

        public void Method()
        {
            var (x, y) = (33, 33.5);
            (double, int) t1 = (4.5, 3);
            (double Sum, int Count) t2 = (4.5, 3);
        }
    }
}