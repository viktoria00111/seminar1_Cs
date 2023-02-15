//54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int a=0;
int b=2;
System.Console.Write("a=");
a=Convert.ToInt32(Console.ReadLine());


if (b>a*a && a<2)
         System.Console.WriteLine("Являются равным   0 и 1"); 
    else System.Console.WriteLine("Не являются равным  0 и 1");