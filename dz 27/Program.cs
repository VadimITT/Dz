

Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int resoult = 0;
while (a>0)
{
    int b = a % 10; //3//2//1
    a = a / 10;//12//1//0
    resoult = resoult+b;//3//5//6
}
Console.WriteLine("summa =  " +resoult);


