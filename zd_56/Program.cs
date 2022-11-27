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

int[,] array = FillArray(row, column); //Создали массив из случайных чисел, и присвоили array
PrintArray(array);// выывели на печать сформированный массив
Console.WriteLine();
Console.WriteLine("Сумма элементов строки каждой строки");
int[] masLin1 = MasSum(array); // сформировали массив для сумм каждой строки
Console.WriteLine("Сформирован одномерный массив: ");
PrintArray1(masLin1); // выводим массив для поиска минимального элемента

Console.WriteLine();
// int  elMinStr=FindMinStr(masLin1); //вызов функции поиска строки с минимальной суммой строки
// PrintArray1(elMinStr); //выводим массив из двух элементов индекса и суммы


//Поиск суммы строк. возвращает массив сумм строк

int[] MasSum(int[,] massiv)
{   int[] masLin = new int[row];  

    {    
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
    }
    return masLin;
}


int  FindMinStr(int [] masLin1)
{
int min = masLin1[0];
int index=0;
for (int i = 1; i<masLin1.Length; i++)
{
    if (masLin1[i]<min)
    {
         index=i;
        min = masLin1[i];      
    
    }
}
return index;

}
  Console.WriteLine();

Console.WriteLine($"Минимальная сумма в строке {FindMinStr(masLin1)}");