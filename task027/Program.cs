// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sumnum(int number)
{
    int result = 0;
    while (number>0)
    {
        result = result + number %10; // Console.WriteLine($" промежуточный результат: {result}");(проверка)
        number /=10;  // Console.WriteLine($" промежуточное число: {number}"); (проверка)
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Math.Abs(num);

Console.WriteLine($"Сумма цифр числа {num1} = {Sumnum(num1)}");