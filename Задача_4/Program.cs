// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Введите первое число:");
var first = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
var second = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
var third = int.Parse(System.Console.ReadLine());

var max = first;

if (max < second)
{
    max = second;
}

if (max < third)
{
    max = third;
}
System.Console.WriteLine("-----------------------------------");
System.Console.Write("Наибольшее число: ");
System.Console.WriteLine(max);


