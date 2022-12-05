Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int result = ((num - (num % 10)) % 100) / 10;

if (num < 100 || num > 999)
{
    Console.WriteLine("Неверное значение");
}
else
{
    Console.WriteLine(result);
}