// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] InputArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"введите {i + 1} -й элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}]={array[i]}");
    }
}
int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int length=ReadInt("введите количество элементов  > " );
int[]array;
array= InputArray(length);
PrintArray(array);
System.Console.WriteLine($"количество чисел больше 0 - { CountPositiveNumber(array)}");
