Console.WriteLine("Введите натуральное число");
int number = int.Parse(Console.ReadLine());
if (number<0)
{
    number=number*-1;
}
int min = number*-1;
while (min<number)
{
    Console.Write(min);
    Console.Write(", ");
    min= min+1;
}
Console.Write(number);