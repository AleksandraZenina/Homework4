// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

  int Get(int num)
{
    int count=0;
    while (num>9)
    {
       count= count+num%10;
       num/=10;
    }
    if (num<10) count = count+num;
    return count;
}
Console.Write("Введите число: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine(Get(a));