//31. Вывести на экран кубы чисел от 1 до N


Random random =new Random();//создали объект
for(int i=0;i<10;i++)
{
    int a=random.Next(1,10);
    int b=(int)Math.Pow(a,3);
    if(b%2==0);

      System.Console.WriteLine($"Число {a}, в кубе {b}");
}
