// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
int a = (N / 10000);
int b = (N / 1000) % 10;
int c = (N / 10) % 10;
int d = (N % 10);
if (a==d && b==c)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}