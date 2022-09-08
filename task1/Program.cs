// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void isPalindrom(int num)
{
    if (num / 1000 == (num % 10 * 10) + (num / 10 % 10)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Console.WriteLine("Введите пяти значное число ");
int num = Convert.ToInt32(Console.ReadLine());
isPalindrom(num);
