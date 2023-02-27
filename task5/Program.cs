Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number<0)
{
    number=number*-1;
}
if (number < 1000)
{
    if (number>99)
    {
        int resultnumber = number%10;
        Console.WriteLine("Последняя цифра ");
        Console.Write(resultnumber);
    }
    else
    {
        Console.WriteLine("Введено некорректное число, попробуй еще!");
    }
    
}
 else
{
    Console.WriteLine("Введено некорректное число, попробуй еще!");
}