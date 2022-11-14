/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/*Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

Console.WriteLine("Заданный массив: ");

FillArray(array);
PrintArray(array);

Console.WriteLine("Отсортированный массив: ");

SortDescendingArray(array);
PrintArray(array);



void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 21);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " " );
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortDescendingArray(int[,] matr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
        }
    }
}
*/


/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка */

/*Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
Console.WriteLine("Заданный массив: ");

FillArray(array);
PrintArray(array);
MinSum(array);





void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 21);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " " );
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum(int[,] matr)
{
    int count = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matr[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            count=i;
        }
    }
    Console.WriteLine("Cтрока номер " + (count+1) + " с наименьшей суммой элементов, равной: " + (minsum));
}
*/

/* Задайте две квадратные матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/*Console.Write("Введите число строк для матрицы А: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для матрицы А и число строк для матрицы В: ");
int columnsArowsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rowsA, columnsArowsB];

Console.Write("Введите число столбцов для матрицы В: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[columnsArowsB, columnsB];

Console.WriteLine("Матрица А: ");
FillArray(matrixA);
PrintArray(matrixA);

Console.WriteLine("Матрица B: ");
FillArray(matrixB);
PrintArray(matrixB);

Console.WriteLine("Произведение матриц А и В: ");
int[,] matrixC = new int[rowsA, columnsB];
GetMatrixProduct(matrixA, matrixB, matrixC);
PrintArray(matrixC);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " " );
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void GetMatrixProduct(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < rowsA; i++)
    {

        for (int j = 0; j < columnsB; j++)
        {
            int numberC = 0;
            for (int k = 0; k < columnsArowsB; k++)
            {
                numberC += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = numberC;
        }
    }
}

*/

/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/*Console.WriteLine("Введите длину: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите высоту: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[a, b, c];
int[] numbers = new int[90]; // массив двузначных чисел

Console.WriteLine("Заданный трехмерный массив: ");

if (a * b * c < 90)
{
    FillArrayTwoDigitNumbersInOrder(numbers);
    FillArrayTwoDigitNumbersRandom(matrix, numbers);
    PrintArray(matrix);
}
else
{
    Console.WriteLine("Произведение параметров превышает 90. Неповторяющихся двузначных чисел недостаточно для заполнения массива.");
}


void FillArrayTwoDigitNumbersInOrder(int[] matrix) //заполнение массива двузначными числами по порядку
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i] = 10 + i;
    }
}

void FillArrayTwoDigitNumbersRandom(int[,,] matrix1, int[] matrix2) //заполнение массива двузначными числами не по порядку
{
    int count = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(2); k++)
            {
                int number = new Random().Next(0, 90); //случайный номер элемента массива двузначных чисел
                while (matrix2[number] == 0)
                {
                    number = count;
                    count++;
                }
                matrix1[i, j, k] = matrix2[number];
                matrix2[number] = 0;
                count = 0;
            }
        }
    }
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " " + (i, j, k) + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/

