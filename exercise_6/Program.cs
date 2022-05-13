int number = new Random().Next(10, 99);
int a = number / 10;
int b = number % 10;
Console.WriteLine("Число Отрезка: " + number);
if (a > b)
{
    Console.WriteLine("Наибольшая цифра: " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + b);
}
if (a == b)
{
    Console.WriteLine("Цифры равны");
}