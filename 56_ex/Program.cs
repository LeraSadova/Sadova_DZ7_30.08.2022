// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//поиск строки с мин.суммой элементов
int minsum = Int32.MaxValue;
int indexLine = 0;
for (int i = 0; i < new_array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < new_array.GetLength(1); j++)
    {
        sum = sum + new_array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine($"Строка №{indexLine} имеет минимальную сумму элементов, равную {minsum}");

