Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое Второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int resoult = a;
for (int i = 1; i<b; i++)
{
    resoult = resoult * a;
}
Console.WriteLine("Число А в степени В равно "+ resoult);


