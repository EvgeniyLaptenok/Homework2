Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

int fri = 6;
int sat = 7;

if (num == fri || num == sat)
{
    
    Console.WriteLine("Выходной день");
}
else if (num < 1 || num >= 8)
    {
        Console.WriteLine("Неверное значение");
    }
else
{
    Console.WriteLine("Будний день");
}
