Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine(" Число " +numberA+  " больше " + numberB);
}
else
{
    Console.WriteLine(" Число " +numberB+  " больше " +numberA);
}