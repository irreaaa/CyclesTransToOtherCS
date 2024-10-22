using System.Numerics;
using System.Runtime.InteropServices;

Console.WriteLine("Введите систему счисления q1 от 2 до 10: ");
int q1 = Convert.ToInt32(Console.ReadLine());
while (q1 < 2 || q1 > 10)
{
    Console.WriteLine("ОШИБКА! Введите систему счисление от 2 до 10");
    q1 = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите систему счисления q2 от 2 до 10: ");
int q2 = Convert.ToInt32(Console.ReadLine());
while (q2 < 2 || q2 > 10)
{
    Console.WriteLine("ОШИБКА! Введите систему счисление от 2 до 10");
    q2 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите число в системе {q1}, которое нужно перевести в систему {q2}: ");
int numberInQ1 = Convert.ToInt32(Console.ReadLine());

int count = Convert.ToString(numberInQ1).Length;
int perem = numberInQ1;
int x1 = 0;

while (x1 < count)
{
    int proverka = perem % 10;
    perem = perem / 10;
    if (proverka > q1)
    {
        Console.WriteLine($"Число {x1} должно быть в системе исчисления {q1}");
    }
    x1++;
}

int length = Convert.ToString(numberInQ1).Length - 1;


int x = numberInQ1;
int perem1 = 0;
int delitel = 1;
double result = 0;
while (perem1 <= length)
{
    int ostatok = (x / delitel) % 10;
    result = result + (ostatok * Math.Pow(q1, perem1));
    delitel = delitel * 10;
    perem1++;
}
Console.WriteLine(result);

int perem2 = Convert.ToInt32(result);
string result1 = "";
while (perem2 > 0)
{
    int ostatok = (perem2 % q2);
    perem2 = perem2 / q2;
    result1 = result1 + ostatok;
}
string reversed = new string(result1.Reverse().ToArray());
Console.WriteLine(reversed);

Console.ReadKey();