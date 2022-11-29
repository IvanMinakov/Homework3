Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a / 10000) == (a % 10))
{
    a = (a / 10) % 1000;
    if ((a / 100) == (a % 10))
        System.Console.WriteLine($"Полиндром");
    else
    {
        System.Console.WriteLine("Не Полиндром");
    }
}
else
{
    System.Console.WriteLine($"Не Полиндром");
}


