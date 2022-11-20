// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите число строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Формируем массив заполненный случайным образом :");

int[,] FillArray(int row, int column)
{

    int[,] massiv = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            massiv[i, j] = new Random().Next(0, 10);
        }
    }
    return massiv;
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{massiv[i, j]}" + " ");

        }
        Console.WriteLine();
    }
}


void PrintArray1(int[] massiv)
{

    for (int j = 0; j < column; j++)
    {
        Console.Write($"{massiv[j]}" + " ");

    }
    Console.WriteLine();

}

int[,] array = FillArray(row, column);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов строки");
int[] masLin1 = MasSum(array);
// PrintArray1(masLin1);
Console.WriteLine();

//Поиск суммы строк. возвращает массив сумм строк

int[] MasSum(int[,] massiv)
{
    int[] masLin = new int[row + 1];
    for (int i = 0; i < row; i++)
    {
        int j = 0;
        int sum = 0;
        for (j = 0; j < column; j++)
        {
            sum = sum + massiv[i, j];
        }
        Console.WriteLine(sum);
        masLin[i] = sum;
    }
    return masLin;
}

int [] FindMinStr(int []array1)
{
int minSumStr = array1[0];
int index=0;
int [] printMasiv=new int[2];
for (int k = 0; k < row - 1; k++)
{
    if (minSumStr > array1[k + 1])
    {
        minSumStr = array1[k + 1];
       printMasiv[1]=k+1;
        printMasiv[0]=minSumStr;
        // Console.WriteLine(k);
        // Console.WriteLine(array1[k + 1]);
    }
}
return printMasiv;

}
  Console.WriteLine();

Console.WriteLine($"Минимальная сумма в строке {FindMinStr(masLin1)}");