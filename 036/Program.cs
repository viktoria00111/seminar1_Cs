// 36.Написать программу вычисления произведения чисел от 1 до N
         

Random random = new Random();
  
int a = random.Next(1,100);  //Получить 1 рандомное число
int b = random.Next(1,100); // Получить 2 рандомное число
int result= a-b;


Console.WriteLine($"{a}-{b}={result}");
