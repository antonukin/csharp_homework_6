// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] GetArray(int[] array)
{
    Console.Write("Введите последовательность 6 целых чисел через пробел.");
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int i = 0; i < numbers.Length; i++)
    array[i] = numbers[i];
    
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int PositiveCount(int[] array)
{
    int posCount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        posCount++;
    }
return posCount;
}

int[] newArray = new int[6];
GetArray(newArray);
PrintArray(newArray);
Console.WriteLine();
int positiveCount = PositiveCount(newArray);
Console.WriteLine(positiveCount);