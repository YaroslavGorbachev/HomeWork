Console.Write(" Введите число (a):  ");
int a = int.Parse(Console.ReadLine());
Console.Write(" Введите число (b):  ");
int b = int.Parse(Console.ReadLine());

int sum = (b * b);
if (sum == a)
{
    Console.WriteLine("Являеться квадратом числа ");
}
else
{

    Console.WriteLine("Неявляеться квадратом числа ");
}