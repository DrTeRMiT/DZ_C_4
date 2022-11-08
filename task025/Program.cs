// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Numpow(int num1, int num2)
{
    int npow = 1;
    for (int i = 1; i <= num2 ; i++)
    {
        npow = npow * num1;  
        // Console.WriteLine(npow);  (проверка работоспособности)
    }
    return npow;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число А в степени В = {Numpow(a, b)}");