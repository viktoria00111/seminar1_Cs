// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int max=0;
int a,b,c;
Console.WriteLine("Введите число");
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
c=Convert.ToInt32(Console.ReadLine());
if (a>b)
max=a;
else

if (b>c) 
max=b;
System.Console.WriteLine($"max={max}");
