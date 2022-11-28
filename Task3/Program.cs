Console.WriteLine("Введите число");
int aaa = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=aaa; i++)
{ 
    System.Console.Write($"{i*i*i}, ");
}
System.Console.WriteLine();