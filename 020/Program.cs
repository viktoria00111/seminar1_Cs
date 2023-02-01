//20 Дано число. Проверить кратно ли оно 7 и 23

System.Console.Write("Введите число: "); 
int number = int.Parse(Console.ReadLine()!); 
 
if (number / 7 == 0 && number / 23 == 0) 
{ 
    System.Console.WriteLine(number + " кратно и 7 и 23"); 
} 
else 
if (number / 7 == 0) 
{ 
    System.Console.WriteLine(number + " кратно 7"); 
} 
else 
{ 
    System.Console.WriteLine(number+" кратно 23"); 
}