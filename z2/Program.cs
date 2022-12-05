Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int number = int.Parse(num);
int[] array = new int[num.Length];

if (number > 99)
{
    Console.WriteLine(num[2]);
}
else
{
    Console.WriteLine("Нет третьего числа");
}
   