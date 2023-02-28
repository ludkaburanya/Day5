namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double y = Math.Cos(x * x) / ((9 * x) - 9) + Math.Pow(Math.Sin(x), 3);
                Console.WriteLine($"y: {y}");
                y = Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3);
                Console.WriteLine($"y: {y:.###}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
}   }