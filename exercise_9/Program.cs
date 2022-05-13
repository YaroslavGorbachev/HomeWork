int number = new Random().Next(10, 200);
if (number / 100 == 0)
{
    Console.WriteLine("Заданное число: "+ number);
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    Console.WriteLine("Заданное число: "+ number);
    Console.WriteLine("Третья цифра: " + number % 10);
}