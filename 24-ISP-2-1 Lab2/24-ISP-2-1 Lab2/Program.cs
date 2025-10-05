//Задание 1 вариант 21: Высокий уровень

//Console.Write("Введите x: ");
//double x = double.Parse(Console.ReadLine());

//Console.Write("Введите z: ");
//double z = double.Parse(Console.ReadLine());

//Console.Write("Введите a: ");
//double a = double.Parse(Console.ReadLine());

//Console.WriteLine($"N={Math.Pow(z + Math.Sqrt(2 * x), 1.0 / 5) / (Math.Exp(x) + Math.Pow(a, 5) * Math.Atan(x)):f4}");

//Задание 2 вариант 21: Средний уровень

//const double n = 8.1;
//const double b = 1.6;

//Console.Write("Введите значение a: ");
//double a = double.Parse(Console.ReadLine());

//double x = Math.Pow(n, b) + Math.Pow(b, 2);

//double calculatedA = Math.Sin(Math.Pow(x, 2) + Math.Pow(b, 2));

//double y = Math.Log(calculatedA) / Math.Log10(Math.Pow(b, 3));

//Console.WriteLine($"Вычисленное x = {x:F4}");
//Console.WriteLine($"Вычисленное a = {calculatedA:F4}");
//Console.WriteLine($"Результат y = {y:F4}");

////Задание 3 вариант 21: Средний уровень

//Console.Write("Введите стаж работы по специальности (лет): ");
//double experience = double.Parse(Console.ReadLine());

//int coefficient;

//if (experience < 2)
//{
//	coefficient = 11;
//}
//else if (experience >= 2 && experience <= 5)
//{
//	coefficient = 12;
//}
//else // если experience > 5
//{
//	coefficient = 13;
//}

//Console.WriteLine($"При стаже {experience} лет коэффициент равен: {coefficient}");