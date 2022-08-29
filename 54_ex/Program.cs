// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
//Задаем размер двумерного массива
Console.WriteLine("введите число строк двумерно массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов двумерно массива n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] new_array = new int[m, n]; // наш массив будет размера m на n

void FillArray(int[,] array) //функция для заполнения массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //теперь обращаемся к элементу массива и заполняем случайными вещественными числами:
            array[i, j] = new Random().Next(-99, 100); //это полуинтервал: [-99;99) 
        }

    }
}
//функция для печати массива
void PrintArray(int[,] array) // в качестве аргумента принимает двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(new_array); // заполнение массива
Console.WriteLine($"Двумерный массива размера m={m} на n={n} имеет вид: ");
PrintArray(new_array); // вывод массива на экран

//сортировка значений массива
for (int i = 0; i < new_array.GetLength(0); i++)
{
    for (int j = 0; j < new_array.GetLength(1) - 1; j++)
    {
        for (int ind = 0; ind < new_array.GetLength(1) - 1; ind++)
        {
            if (new_array[i, ind] < new_array[i, ind + 1]) 
            {
                int temp = 0;
                temp = new_array[i, ind];
                new_array[i, ind] = new_array[i, ind + 1];
                new_array[i, ind + 1] = temp;
            }
        }
    }
}
Console.WriteLine($"Массив, отсортированный по убыванию по строкам имеет вид: ");
PrintArray(new_array); // вывод массива на экран