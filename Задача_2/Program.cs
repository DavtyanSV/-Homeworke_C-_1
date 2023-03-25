// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
var first_number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
var second_number = int.Parse(Console.ReadLine());

if (first_number > second_number)
{
    System.Console.WriteLine($"{first_number} больше чем {second_number}");
}
else if (second_number > first_number)
{
    System.Console.WriteLine($"{second_number} больше чем {first_number}");
}
else if (first_number == second_number)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    System.Console.WriteLine("Какая-то ошибка, введите именно число!");
}

