// 10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int n=453;
int d0,d1,d2;
d0=n/100;
d1=n/10%10;
d2=n%10;
System.Console.WriteLine($"{d0} {d1} {d2}");
System.Console.WriteLine($"{d2}");
