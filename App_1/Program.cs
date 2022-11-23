// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

FillArray(array);
PrintArray(array);


void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble(),2);
        }
    }
}

void PrintArray(double[,] array)
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
