//35.Подсчитать сумму цифр в числе. Сделать подпрограмму.
int Osnova(int n)
{
    int counter=0;//счетчик
    while(n!=0)
    {
        counter++;
        n/=10;//n=n/10
    }
    //System.Console.WriteLine(counter);//мусорный вывод
    return counter;
}
System.Console.WriteLine(Osnova(2001));
