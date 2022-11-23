// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);

Console.Write("Введите индекс столбца: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindAverage(array,num));

double FindAverage(int[,] array, int num)
{
    double counter = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        counter = counter + array[i, num];
    }
    double average = Math.Round((counter / n),2);
    return average;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
