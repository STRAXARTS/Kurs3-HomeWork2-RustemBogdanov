// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 | n > 7)
    Console.WriteLine("Вы из другого мира и наши временные рамки к вам неприменимы. Сначала станьте человеком.");
else if (n > 0 && n < 6)
{
    Console.Write("К сожалению - это будний день, а именно ");
        if (n == 1)
            Console.WriteLine("Понедельник");
        if (n == 2)
            Console.WriteLine("Вторник");
        if (n == 3)
            Console.WriteLine("Среда");
        if (n == 4)
            Console.WriteLine("Четверг"); 
        if (n == 5)
            Console.WriteLine("Пятница. Но, почти выходной."); 
}
else if (n > 5 && n < 8)
{
    Console.Write("Ура! Выходной! ");
        if (n == 6)
            Console.WriteLine("Суббота!");
        if (n == 7)
            Console.WriteLine("Воскресенье! Хуже Субботы, но тоже годится.");
}