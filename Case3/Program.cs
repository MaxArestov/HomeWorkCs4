// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Задание должно быть выполнено в методах.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] massDigits = new int[8];
Console.WriteLine("Введите 8 цифр, разделяя их клавишей Enter:");
FillArray(massDigits);
PrintArray(massDigits);



void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] mass)
{
    int line = mass.Length;
    int count = 0;
    Console.Write($"Элементы массива: [");
    while (count < line)
    {
        if (count != line-1)
        {
        Console.Write($"{mass[count]}, ");
        count++;
        }
        else 
        {
            Console.Write($"{mass[count]}");
            count++;
        }
    }
    Console.Write("]");
}