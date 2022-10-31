Console.Write("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day > 7)
{
    Console.WriteLine("Ошибка ввода! В неделе всего 7 дней!");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}


