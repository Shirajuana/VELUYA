namespace PS_03_HERON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side of a triangle: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second side of a triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third side of a triangle: ");
            double c = Convert.ToDouble(Console.ReadLine());

            
            HeronFormula(a,b,c);
            Console.ReadKey();

        }
        
        public static void HeronFormula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"The area of the three sides of a triangle is: {area:F2}");
        }
    }
}
