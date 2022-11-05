// 04. Найти максимальное из трех чисел

Console.Write("Введи цифру a  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи цифру b  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи цифру c  ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
{
    max = b;
}
if (c > b)
{
    max = c;
}

Console.Write("max = " + max);