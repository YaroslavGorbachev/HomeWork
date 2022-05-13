int number = new Random().Next(100, 999);
int a = number / 10;
int b = a % 10;
Console.WriteLine("Рандомное число" + number);
Console.WriteLine("Вторая цифра: " + b);