int number = new Random().Next(1, 100); // заданное число
int divider = new Random().Next(1, 5); // делитель
int remains = number % divider; // остаток от деления
Console.WriteLine("Заданное число: " + number);
Console.WriteLine("Делитель: " + divider);
if (number % divider == 0)
{
    Console.WriteLine("Число " + number + " кратно числу " + divider);
}
else
{
    Console.WriteLine("Число " + number + " не кратно числу " + divider);
    Console.WriteLine("Остаток от деления: " + remains);
}
if (number == divider)
{
    Console.WriteLine("Числа равны");
}
if (number < divider)
{
    Console.WriteLine("Так не нужно делать (ошибка)");
}