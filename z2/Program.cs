namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите вещественное число 'x'");
                double x = Convert.ToDouble(Console.ReadLine());

                if (-3 < x && x < -1)
                {
                    Console.WriteLine($"f(x)={2 * x}");
                }
                if (-1 < x && x < 3)
                {
                    Console.WriteLine($"f(x)={-2 / x}");
                }
                else if (x<=3)
                Console.WriteLine($"f(x)={x}");

                else throw new Exception("Ошибка выхода из диапазона допустимых значение х");   
            }   

            catch (FormatException fx)
            {
                Console.WriteLine("Ошибка!" + fx.Message);
            }

            catch (DivideByZeroException fx)
            {
                Console.WriteLine("Ошибка!" + fx.Message);
            }
            catch (Exception fx)
            {
                Console.WriteLine("Ошибка!" + fx.Message);
            }
            Console.ReadLine();
        }
    }
}