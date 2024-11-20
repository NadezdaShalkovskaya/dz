Console.Write("Введите значение х ");
double x = 0;
Console.Write("Введите количество членов ряда n ");
int n = 0;
Convert.ToInt32(Console.ReadLine());
double sum = 0;
for (int i = 0; i < n; i++)
{
    double numerator = Math.Cos(2 * i * x);
    double denominator = (i+ 1) * (i+2);
    sum += numerator / denominator;
}
    Console.WriteLine($"Сумма первых {n} членов ряда: {sum}");

