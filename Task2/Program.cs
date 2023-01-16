/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет   */

Console.Write("Введите первое число: a = ");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.Write("Введите второе число: b = ");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

if (a == b * b)
{
    Console.WriteLine("Число b является квадратом числа a");
}
else
{
    Console.WriteLine("Число b не является квадратом числа a");
}