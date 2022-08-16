// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine());
// if (num > 99999 || num < 10000)
// {
//     Console.WriteLine("Введено неверное число!"); return;
// }
// if (num / 10000 != num % 10)
// {
//     Console.WriteLine("Введенное число не является палиндромом");
// }
// else if ((num / 1000) % 10 != (num % 100) / 10)
// {
    
//     Console.WriteLine("Введенное число не является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {num} является палиндромом");
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Clear();
// Console.WriteLine("Введите X1: ");
// double numX1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y1: ");
// double numY1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Z1: ");
// double numZ1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите X2: ");
// double numX2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Y2: ");
// double numY2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Z2: ");
// double numZ2 = Convert.ToDouble(Console.ReadLine());
// double distanceAB;
// Console.WriteLine($"Точка 1 ({numX1}, {numY1}, {numZ1}) ; Точка 2 ({numX2}, {numY2}, {numZ2})");
// Console.Write("Расстояние между Точкой 1 и Точкой 2 = ");
// Console.WriteLine(distanceAB = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2) + Math.Pow((numZ2 - numZ1), 2)));


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int count = 1;
// while (count <= Math.Abs(num))
// {
//     Console.Write($"|{Math.Pow(count++, 3)}|");
// }

