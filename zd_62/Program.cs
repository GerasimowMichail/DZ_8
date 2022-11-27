// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите размер массива");

int n = Convert.ToInt32(Console.ReadLine());

int[,] arraySpiral=Spiral(n);
printArray(arraySpiral);

int [,] Spiral(int n)
{
int [,] masiv = new int[n,n];
int index=1;
for(int k=0; k<=n/2; k++)// Количество прямоугольников
{
    for(int i=k; i<n-k; i++) //просматриваем строку горизонтальную слева направо
    {
        masiv[k,i ]=index;
        index++;
    }
   
    for(int j=k+1; j<n-k-1; j++) //просматриваем столбец справа
    {
        masiv[j,n-k-1]=index;
        index++;     

    }    

      for(int z=n-k-1; z>=k;z--) //просматриваем нижную строку
      {
        masiv[n-k-1, z]=index;
        index++;       
      }   

      for(int m=n-k-2; m>k;m--) //просматриваем столбец слева
      {
        masiv[m,k]=index;
        index++;        
      }    
}
return masiv;
}

void printArray(int [,] masiv)
{
for(int i=0;i<n;i++)
{
    for(int j=0; j<n;j++)
    {
        if (masiv[i,j]<10)
        {
        Console.Write("0"+$"{masiv[i,j]}"+" "); 
        }
        else Console.Write($"{masiv[i,j]}"+" "); 
    }
    Console.WriteLine();
}
}

// Console.WriteLine("Введите размер массива");

// int n = Convert.ToInt32(Console.ReadLine());
// var matrix = new int[n, n];
//             var rand = new Random();
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     matrix[i, j] = rand.Next(100);
//                 }
//             }
//             Console.WriteLine("Исходная матрица: ");
//             MatrixOutput(matrix);
//             // создаем массив
//             int[] arr = GetArray(matrix);
//             Console.WriteLine("Исходный массив:");
//             ArrayOutput(arr);
 
//             // сортируем массив
//             Array.Sort(arr);
//             Console.WriteLine("После сортировки:");
//             ArrayOutput(arr);
 
//             // преобразуем матрицу
//             matrix = SpiralConvertion(arr);
 
//             Console.WriteLine("Результат: ");
//             MatrixOutput(matrix);
//             Console.ReadKey();
        
 
//          void MatrixOutput(int[,] mx)
//         {
//             int n = mx.GetLength(0);
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write("{0,4}", mx[i, j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
 
//          void ArrayOutput(int[] arr)
//         {
//             Console.WriteLine(String.Join(", ", arr));
//             Console.WriteLine();
//         }
 
//         int[] GetArray(int[,] mx)
//         {
//             return mx.Cast<int>().ToArray();
//         }
 
//         int[,] SpiralConvertion(int[] arr)
//         {
//             var n = (int) Math.Sqrt(arr.Length);
//             var matrix = new int[n, n];
 
//             int m = n / 2 + n % 2,
//                 len = n,
//                 count = 0;
 
//             for (int i = 0; i < m; i++)
//             {
//                 // Верх
//                 for (int j = 0; j < len; j++) matrix[i, i + j] = arr[count++];
//                 // Право
//                 for (int j = 1; j < len; j++) matrix[i + j, n - i - 1] = arr[count++];
//                 len -= 2;
//                 // Низ
//                 for (int j = len; j >= 0; j--) matrix[n - i - 1, i + j] = arr[count++];
//                 // Лево
//                 for (int j = len; j >= 1; j--) matrix[i + j, i] = arr[count++];
//             }
 
//             return matrix;
//         }