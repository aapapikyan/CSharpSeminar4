// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Exp(int num, int power)
{
    int result = num;
    for(int i = 1; i < power; i++)
    {
        result = num*result;
    }
    return result;
}

int number = Promt("Введите число");
int power = Promt("Введите натуральную степень");
if(power > 0)
{
System.Console.WriteLine($"Число {number} в степени {power} равняется {Exp(number, power)}");
}
else
{
    System.Console.WriteLine("Степень должна быть больше ноля");
}