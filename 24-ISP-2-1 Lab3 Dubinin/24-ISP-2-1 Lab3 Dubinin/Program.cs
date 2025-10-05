Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int result = (num / 100) * 100 + (num % 10) * 10 + (num / 10) % 10;

Console.WriteLine($"Результат: {result}");