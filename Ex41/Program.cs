// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray (int m)         //Ввод чисел и заполнение массива
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PrintArrayCounter(int[] array)    //Печать массива и счетчик нужных чисел
{
    int counter = 0;
    Console.Write("Вы ввели: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("] ");
    return counter;
}
Console.Clear();
Console.WriteLine("Введите количество цифр, которые будете вводить:");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(M);
int count = PrintArrayCounter(arr);
Console.WriteLine($"Чисел больше нуля: {count}");