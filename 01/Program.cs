
Console.Write("Введи цифру a  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи цифру b  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Является квадратом b");
}
else if ( a != b * b)
{
    Console.WriteLine("Не является квадратом b");
}