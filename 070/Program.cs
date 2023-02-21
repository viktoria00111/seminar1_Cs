// 70.Показать натуральные числа от 1 до N, N задано
int N=20;
int i=0;

void Loop(int i, int N);


{
    System.Console.Write($"{i,4}");
    if(i<N) Loop(i+1,N);
}

Loop(1,20);


