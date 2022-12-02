// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("введите числа через пробел: ");
int[]array = Array.ConvertAll(Console.ReadLine().Split( ), int.Parse);

int num = Elements(array);
Console.WriteLine($"количество чисел больше 0 -> {num}");

int Elements(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) num ++;
    }
    return num;
}

