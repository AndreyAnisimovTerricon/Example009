Console.WriteLine("Введите число N");
double n = double.Parse(Console.ReadLine());
n = Math.Abs(n);

Console.Write(n + "->");

for(int i=1; i<=n;i++)
{
    Console.Write(Math.Pow(i,3)+" ");
}