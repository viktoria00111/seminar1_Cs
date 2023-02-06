//35.Подсчитать сумму цифр в числе. Сделать подпрограмму.
int n=2001;
System.Console.WriteLine($"Заданное число={n} ");

//счетчик

    int counter=0;
    int sum=0;
    while(n!=0)
    {
        counter++;
        int d=n%10;
        sum+=d;
        n/=10;
    }


System.Console.WriteLine(counter);
System.Console.WriteLine(sum);

