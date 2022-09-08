// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string cubeList(int N)
{
    string res = "1";
    for (int i = 2; i <= N; i++)
    {
        res = res + $", {i*i*i}";
    }
    return res;
}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(cubeList(N));
