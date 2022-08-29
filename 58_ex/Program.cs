// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
//Задаем размер двумерного массива
Console.WriteLine("введите размерность для матриц (они будут квадратные):");
int m = Convert.ToInt32(Console.ReadLine());

//я их задам одинакового размера

int[,] new_array1 = new int[m, m]; // наш массив будет размера m на n
int[,] new_array2 = new int[m, m]; // наш массив будет размера m на n

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
//выводим нашу красоту на экран
FillArray(new_array1); // заполнение массива
Console.WriteLine($"Первый массив имеет вид: ");
PrintArray(new_array1); // вывод массива на экран
FillArray(new_array2); // заполнение массива
Console.WriteLine($"Первый массив имеет вид: ");
PrintArray(new_array2); // вывод массива на экран

int[,] new_array3 = new int[m, m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            new_array3[i, j] = new_array3[i, j] + (new_array1[i, k] * new_array2[k, j]);
        }
    }
}
Console.WriteLine("Произведение первого и второго массива равно:");
PrintArray(new_array3);