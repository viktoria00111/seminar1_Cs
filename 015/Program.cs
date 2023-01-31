// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.WriteLine("Введите число");
string a = System.Console.ReadLine();
if (a.Length > 2)
        System.Console.WriteLine(a[2]);
else
    System.Console.WriteLine("NO");


int N1=n;
while(n!=0)
{
    counterDigit++;
    n=n/10;
}

int d=N1/(int)Math.Pow(10,counterDigit-3)%10;
if (N1>=99) 
System.Console.WriteLine($"Третья цмфра в числе = {d}");
if(n<99)System.Console.WriteLine("NO");
