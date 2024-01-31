double f (double nn)
{
    double x = 1;
    for (int i = 1; i <= nn; i++)
        x = x * i;
    return x;
}
double s (double a, double k)
{
    double x=1;
    for(int i = 1;i <= k; i++)
        x = x * a;
    return x;
}
Console.WriteLine("введите x,y,a,b,k,i");
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double k = double.Parse(Console.ReadLine());
double i = double.Parse(Console.ReadLine());
double y1 = (Math.Sqrt(s(a, k) - s(b, i)) / (x + b) + f(y + a));
Console.WriteLine($"y ={y1}");