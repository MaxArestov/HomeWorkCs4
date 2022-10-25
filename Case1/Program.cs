// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число, которое нужно возвести в степень: ");
bool parsedRaised = int.TryParse(Console.ReadLine(), out int raised);
Console.Write("Введите число, означающее степень: ");
bool parsedRate = int.TryParse(Console.ReadLine(), out int rate);
if (!parsedRaised || !parsedRate)
{
    Console.WriteLine("Введены некорректные данные: ");
    return;
}
Console.WriteLine($"{raised} в степени {rate} = {Exponent(raised, rate)}");


int Exponent(int x, int y)
{
    int constant = x;
    for (int i = 1; i < y; i++)
    {
        x = x * constant;
        Console.WriteLine(x); //Checking for every digit, may be cuted!
    }
    return x;
}