static void Main(string[] args)
{
    void Factorial(double nn, out double x)
    {
        x = 1;
        for (int i = 1; i < nn; i++)
        {
            x = x * i;
        }
    }
    void Stepen(double A, double K, out double x)
    {
        x = 1;
        for (int i = 1; i < K; i++)
        {
            x *= A;
        }
    }
    Console.WriteLine("a=");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("b=");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("k=");
    double k = double.Parse(Console.ReadLine());
    Console.WriteLine("l=");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("x=");
    double X = double.Parse(Console.ReadLine());
    Console.WriteLine("y=");
    double y = double.Parse(Console.ReadLine());
    Stepen(a, k, out double S1);
    Stepen(b, l, out double S2);
    Factorial(y + a, out double p1);
    double F = Math.Sqrt(S1 - S2) / (X + b) + p1;
    Console.WriteLine($"F= {F}");
}