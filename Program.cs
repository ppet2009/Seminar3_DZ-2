/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


int SecondNumber(int num)

{
    int hundred = num % 100;
    int ed = hundred / 10;
    int result = ed;
    return result;
}

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);
Console.WriteLine($"Вторая цифра введеного трехзначного числа = {result} ");

