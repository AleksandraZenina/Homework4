//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
while (true)
{
    Console.Write("Введите число А: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    double b = double.Parse(Console.ReadLine());
       
    if (b<0) break;  
    Console.WriteLine (Math.Pow(a,b)); 
}
    
