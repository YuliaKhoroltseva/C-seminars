Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int sqr2 = number2 * number2;
if(sqr2 == number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}
