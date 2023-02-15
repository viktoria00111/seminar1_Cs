// 56.Написать программу копирования массива

int[] a= {3, 2, 7, 1, 9,3,8};

PrintArray(a);

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]}. ");
}

