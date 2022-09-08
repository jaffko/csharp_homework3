// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.

string isPalindrom(long num)
{
    int numLen = 1;
    long index = 10;
    while (num / index != 0)
    {
        numLen++;
        index = index * 10;
    }
    index = 1;
    long[] array = new long[numLen];
    for (int k = 0; k < numLen; k++)
    {       
        array[k] = num / index % 10;
        index = index * 10;
    }
    int i = 0;
    int length = array.Length;
    while (i < length / 2)
    {
        if (array[i] != array[length - 1 -i]) return "Нет";
        i++;
    }
    return "Да";

}
Console.WriteLine("Введите число");
long num = Convert.ToInt64(Console.ReadLine());
Console.WriteLine(isPalindrom(num));
