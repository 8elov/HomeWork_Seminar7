// Напишите программу, которая будет принимать от пользователя позицию (M, N) 
// двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. 
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

int[,] array = new int[5,5];

FillArray(array);
PrintArray(array);

Console.Write("Введите позицию M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindElement(m,n));


string FindElement(int m, int n)
{
    if ((m > 0 & m < array.GetLength(0)) & (n > 0 & n < array.GetLength(1)))
    {
        return Convert.ToString(array[m,n]);
    }
    return ("Такой позиции в массиве нет");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
