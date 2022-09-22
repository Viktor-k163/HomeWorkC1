// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе число");
int number2 = int.Parse(Console.ReadLine());

int max = number1;
int min = number1;

if (number1 > number2)
{
    Console.WriteLine($"число {number1} больше числа {number2}");

}
else
{
    Console.WriteLine($"число {number1} меньше числа {number2}");
}*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("введите первое число");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("введите второе число");
// int number2 = int.Parse(Console.ReadLine());
// Console.WriteLine("введите третье число");
// int number3 = int.Parse(Console.ReadLine());
// int max = number1;

// if (number2 > max)
// {
//     max = number2;
// }
// if (number3 > max)
// {
//     max = number3;
// }
// Console.WriteLine($"Максимальное число = {max}");

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("введите число");
// int number = int.Parse(Console.ReadLine());
// if (number%2==0)
// {
//     Console.WriteLine("Число является четным");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите Число N ");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine("Все четные числа от 1 до N: ");
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}