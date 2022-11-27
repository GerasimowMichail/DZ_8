// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите число строк массива: ");
int row=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Формируем массив заполненный случайным образом :");

int [,] FillArray(int row, int column)
{
   
    int [,] massiv= new int [row,column];

    for(int i=0; i<row;i++)
    {
        for(int j=0; j<column; j++)
        {
            massiv[i,j]=new Random().Next(0,10);
        }
    }
    return massiv;
}

void PrintArray(int [,] massiv)
{
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            Console.Write($"{massiv[i,j]}"+ " ");
            
        }
        Console.WriteLine();
    }
}

int [,] array = FillArray(row, column);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированый массив");

int [,] arraySort=SortMassiv(array);
PrintArray(arraySort);

int [,] SortMassiv(int [,] massiv)
{   for (int k=0; k<((row-1)*(column)); k++)
        {
            for(int i=0; i<row; i++)
            { int j=0;
                for ( j=0; j<column-1; j++)
                {
                    if (massiv[i,j]<massiv[i,j+1])
                    {
                        int temp = massiv[i, j+1];
                        massiv[i,j+1]=massiv[i,j];
                        massiv[i,j]=temp;
                        
                    }                    
                }
            
            }
        }

    return massiv;
}