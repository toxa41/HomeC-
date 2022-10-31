Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int reverse = 0;
int division = 0;
while (number > 0)
{
    division = number % 10;
    reverse = reverse * 10 + division;
    number = number / 10;
}
if (temp == reverse)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}