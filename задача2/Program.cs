//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.WriteLine("Введите число n :");
int n = int.Parse(Console.ReadLine());
if ( n<=7)
{
    if (  n==6 || n ==7)
    {
         Console.WriteLine("выходной день");
    }
    else
    {
        Console.WriteLine("не выходной день");
    }
}
else
{
    Console.WriteLine("такого дня не существует");
}
    


