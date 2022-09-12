Console.WriteLine("ВВедите количество вводимых чисел");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите числа");
int x;
int kol=0;
for (int i=0; i<M; i++)
{
    x = Convert.ToInt32(Console.ReadLine());
    if (x>0) kol++;
}
Console.WriteLine($"Чисел больше нуля {kol}");