/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
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

*/

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;
    
    if (amount < 3 || amount > 3)
        {
            Console.WriteLine("Вы ввели не трехзначное число");
        }
    else
        {
            Console.WriteLine(InCenter(number));
        }
int ReadInt(string message)

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a % 10));
    return result;
}


