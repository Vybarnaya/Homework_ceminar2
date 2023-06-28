//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число n:");
int n = int.Parse(Console.ReadLine());
int result = ((n/10) - (n/100)*10);
Console.WriteLine(result);