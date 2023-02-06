//33.Возведите число А в натуральную степень B используя цикл
  Console.Write("Введите a: "); // Число
  int num = int.Parse(Console.ReadLine());
  
  Console.Write("Введите b: "); // Степень
  int n = int.Parse(Console.ReadLine());
  
  int num_n=1;
  for(int i=0; i<n; i++) 
    {
      num_n*=num;
    }
  Console.WriteLine($"{num} ^ {n} = {num_n}");
  Console.ReadKey();
  return 0;
 

 

    





