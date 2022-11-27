// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк 1-го массива: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-го массива: ");
int column1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число строк 2-го массива: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-го массива: ");
int column2= Convert.ToInt32(Console.ReadLine());

if((row1!=column2))
{
    Console.WriteLine("Данные матрицы невозможно перемножить");
}
else{
int [,] masiv1=FillArray(row1, column1);
PrintArray1(masiv1);
Console.WriteLine();
int [,] masiv2=FillArray(row2,column2);
PrintArray2(masiv2);
Console.WriteLine();
int [,] matrMulti=MatrixMultiplication(masiv1,masiv2);
PrintArray(matrMulti);


 
int [,] FillArray(int row, int column)
{
   
    int [,] massiv= new int [row,column];

    for(int i=0; i<row;i++)
    {
        for(int j=0; j<column; j++)
        {
            massiv[i,j]=new Random().Next(10,101);
        }
    }
    return massiv;
}

void PrintArray1(int [,] massiv)
{
    for(int i=0; i<row1; i++)
    {
        for(int j=0; j<column1; j++)
        {
            Console.Write($"{massiv[i,j]}"+ " ");
            
        }
        Console.WriteLine();
    }
}

void PrintArray2(int [,] massiv)
{
    for(int i=0; i<row2; i++)
    {
        for(int j=0; j<column2; j++)
        {
            Console.Write($"{massiv[i,j]}"+ " ");
            
        }
        Console.WriteLine();
    }
}

void PrintArray(int [,] massiv)
{
    for(int i=0; i<row1; i++)
    {
        for(int j=0; j<column2; j++)
        {
            Console.Write($"{massiv[i,j]}"+ " ");
            
        }
        Console.WriteLine();
    }
}

int [,] MatrixMultiplication(int [,] a, int [,] b)
{
    int [,] c = new int [row1,column2];
    for(int i=0; i<row1;i++)
    {
        for (int j=0; j<column2;j++)
        {
            int sum=0;
            for(int k=0; k<row2;k++)
            {
                sum=sum+masiv1[i,k]*masiv2[k,j];
            }
            c[i,j]=sum;

        }
    }

    return c;
}
}