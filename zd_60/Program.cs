// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите 1-ю размерность массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ю размерность массива: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ю размерность массива: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Формируем трехмерный массив их неповторяющихся двузначных чисел: ");

int[,,] massiv3D = new int[x, y, z];

int[] mas = new int[massiv3D.GetLength(0)*massiv3D.GetLength(1)*massiv3D.GetLength(2)];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(10, 100);
    int temp = mas[i];
    for (int j = 0; j < i - 1; j++)
    {
        if (temp == mas[j])

        {
           
            mas[j] = new Random().Next(10, 100);
        }

    }
}

Console.WriteLine();


int kmn=0;
for(int k=0; k<x;k++)

{
    for(int m=0; m<y; m++)
    {
        for(int n=0; n<z; n++)
        {
            massiv3D[k,m,n]=mas[kmn];
            kmn++;
            Console.Write($"    {massiv3D[k,m,n] } ");
            Console.Write( $"( {k}" +$"{m}" + $"{n} )");

        }
        Console.WriteLine();
    }
}


Console.WriteLine();



