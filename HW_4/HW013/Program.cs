
Console.WriteLine("Введите длинну массива: ");
int [] array = new int [20];
int rand = new Random();
for (int i = 0; i < len; i++)

{
    array[i] = rand.Next(1,5);
}
Console.WriteLine(rand);
