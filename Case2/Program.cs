// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число, чтобы получить сумму цифр: ");
bool parsedNum = int.TryParse(Console.ReadLine(), out int num);
if (!parsedNum)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}
int sum = SumOfNumbers(num);
Console.WriteLine($"Сумма всех цифр введенного числа: {sum}");

int SumOfNumbers(int x)
{
    int y = 0;
    for (int i = 1; x != 0; i++)
    {
        y += (x % 10);
        x /= 10;
    }
    return y;
}