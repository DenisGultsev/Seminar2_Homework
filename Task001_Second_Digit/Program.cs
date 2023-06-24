﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **вторую** цифру этого числа.

while (true) // начинаем цикл, который будет продолжаться до тех пор, пока пользователь не введет корректное трехзначное число
{
    Console.Write("Введите трехзначное число: "); // выводим сообщение, запрашивающее ввод трехзначного числа, на консоль
    int number; // объявляем переменную number типа int.

    // проверяем, является ли вводимое пользователем значение целым числом и находится ли оно в диапазоне от 100 до 999 включительно
    if (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
    {
        Console.WriteLine("Ошибка! Введите корректное трехзначное число."); // выводим сообщение о некорректном вводе на консоль
    }
    else // иначе
    {
        int secondDigit = (number / 10) % 10; // вычисляем вторую цифру числа
        Console.WriteLine($"{number} → {secondDigit}: Вторая цифра числа."); // выводим введенное число и его вторую цифру на консоль
        break; // заканчиваем цикл while при помощи оператора break
    }
}
