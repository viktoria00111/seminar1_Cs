// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


int[,] a=new int[3,4]{{1,4,7,2},{5,9,2,3},{8,4,2,4}};
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
                    a[i,j]=i+j;

{
    for(int i=0;i<a.GetLength(0);i++)
    {
    for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
    System.Console.WriteLine();
    }

}
