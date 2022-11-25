// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10; 
        num = num / 10;
    }
    return sum;
}  
if (number < 0) number = - number;
int sumDigit = SumDigit(number);
Console.WriteLine($"sum digit num {sumDigit}");
