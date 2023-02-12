// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Promt(string message)
{
    System.Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Digits(int input)
{
int result = 1;
int delitel = 10;
int count = 0;    
while (result > 0)
{
    result = input / delitel;
    count++;
    delitel = delitel*10;
}
return count;
}

int number = Promt("Введите число");
int rest = 0;
int delitel = 10;
int sum = 0;
for(int i = 0; i < Digits(number); i++)
{
    rest = number % delitel;
    rest = rest / (delitel / 10);
    delitel = delitel*10;
    sum = sum + rest;
}
System.Console.WriteLine($"Сумма цифр числа {number} равняется {sum}");