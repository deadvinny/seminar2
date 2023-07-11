// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = 7;
int num2 = 23;
int div1 = number % num1;
int div2 = number % num2;

if (div1 == 0 && div2 == 0) 
    {
        Console.WriteLine($"Число {number} кратно 7 и 23.");
    }
else 
    {
        Console.WriteLine($"не кратно");
    }