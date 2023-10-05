Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100 | n > 999)
    Console.WriteLine("Вы ввели не трёхзначное число. Запустите программу снова и повторите ввод.");
else
{
    int ost1 = n % 10;
    int ost2 = n % 100;
    Console.WriteLine((ost2 - ost1) / 10);
}
