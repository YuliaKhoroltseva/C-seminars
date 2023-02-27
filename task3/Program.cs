Console.Write("Введите номер дня недели (от 1 до 7): ");
int numberday = int.Parse(Console.ReadLine());

if(numberday >7)
{
    Console.WriteLine("Неверно введен номер дня недели");
}
if(numberday <1)
{
    Console.WriteLine("Неверно введен номер дня недели");
}
if(numberday == 1)
{
    Console.WriteLine("Понедельник");
}
if(numberday == 2)
{
    Console.WriteLine("Вторник");
}
if(numberday == 3)
{
    Console.WriteLine("Среда");
}
if(numberday == 4)
{
    Console.WriteLine("Четверг");
}
if(numberday == 5)
{
    Console.WriteLine("Пятница");
}
if(numberday == 6)
{
    Console.WriteLine("Суббота");
}
if(numberday == 7)
{
    Console.WriteLine("Воскресенье");
}
