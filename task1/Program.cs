// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string isPalindrom(int num)
{
    if (num / 1000 == (num % 10 * 10) + (num / 10 % 10)) return "Да";
    else return "Нет";
}

Console.WriteLine("Введите пяти значное число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPalindrom(num));
