// напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным

Console.WriteLine ("Введите день недели...");
int dayofweek = int.Parse (Console.ReadLine());

if (dayofweek == 6 || dayofweek == 7) 
{
Console.WriteLine ("Ответ: Выходной день.");
}
else if (dayofweek <= 5) 
{
    Console.WriteLine ("Ответ: Будний день.");
}
else if (dayofweek > 7) 
{
    Console.WriteLine ("Ошибка: В неделе всего 7 дней!");		
}
