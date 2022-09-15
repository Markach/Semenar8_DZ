// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] SpiralMatr(int n)
{
    int[,] matr = new int[n,n];
    int number=1;
        for (int i = 0; i <= n/2; i++)
            {
                for (int j = i; j < n-i; j++) matr[i,j]=number++;
                for (int k = i+1; k < n-i; k++) matr[k,n-i-1]=number++;
                for (int j = n-i-2; j >= i; j--) matr[n-1-i,j]=number++;
                for (int k = n-2-i; k > i; k--)  matr[k,i]=number++;
            }
return matr;
}
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j]/10 <= 0) Console.Write($" {array[i,j]} ");
                    else Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
        }
}
try
{
    Console.Write("Введите натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [,] resArray = SpiralMatr(n);
    PrintArray(resArray);
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}
