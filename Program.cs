// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (number1 > number2)
    {
    Console.Write("Большее число: ");
    Console.WriteLine(number1);
    }
        
    else
    {
    Console.Write("Большее число: ");
    Console.WriteLine(number2);
    }
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    if (number1 == number3)
            Console.WriteLine("Числа равны");
    else {}    
}
else
{
    if (number1 > number2)
    {
        if (number1 > number3)
        {
        Console.Write("Большее число: ");
        Console.WriteLine(number1);
        }
        else {}      
    }
    else
    {
        if (number2 > number3)
        {
        Console.Write("Большее число: ");
        Console.WriteLine(number2);
        }
        else
        {
        Console.Write("Большее число: ");
        Console.WriteLine(number3);
        }
    }
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
    Console.WriteLine("Это четное число");

else
    Console.WriteLine("Это нечетное число");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= number)
{
    Console.Write(current + " ");
    current = current + 2;
}