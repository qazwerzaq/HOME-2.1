// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int answer = 0;
if(num >= 100 && num <= 999)
    {
    int a = num / 100;
    int b = (num / 10) % 10;
    int c = num % 10;
    answer = a * 10 + c;
    Console.WriteLine(answer);
    }
else
    {
    Console.WriteLine("Вы ввели неправильное число");
    }


