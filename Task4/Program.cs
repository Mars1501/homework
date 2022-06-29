Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
for(i = 1; i <= num; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
