// Напишите программу,которая выводит третью цифру
// заданного числа или сообщает, что ретьей цифры нет

Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int numTemp = num;
int count = 0;

while(numTemp > 0)
{
    numTemp /=10;
    count++;
}
if (count - 3 >=0)
{
    while (count-3 > 0)
    {
        num = num/10;
        count--;
    }
    Console.WriteLine($"Третья цифра {num % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
