﻿Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (A > 0)
    {
        int num = A % 10;
        A = A / 10;
        sum = sum + num;
    }
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);
