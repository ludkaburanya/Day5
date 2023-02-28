namespace Z3
{
    class Program
    {
        static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }
        static void Main(string[] args)
        {
            double b;
            for (int i = 2; i < 7; i++)
            {
                PowerA3(i, out b);
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}