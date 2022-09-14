// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] table)
    {
        Random random = new Random();
        for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[i,j] = random.Next(1,10);
                    }
            }
    }
void PrintArray(int[,] table)
    {
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j] + "\t" );
                }
            Console.WriteLine();
        }
    }
void Sum(int[,] table)
    {
        for(int i=0;i<table.GetLength(0); i++)
            {
                int sum1=0; 
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            sum1+= table[i,j];
                        } 
                Console.WriteLine($"Сумма элементов {i+1} строки: " + sum1);            
            }
    }
int SumRows(int[,] array, int i)
    {
        int sum = array[i,0];
            for (int j = 1; j < array.GetLength(1); j++)
                {
                    sum += array[i,j];
                }
    return sum;
    }
void  MinSumRows(int [,]table)
    {
        int result =0;
        int min = SumRows(table,0);
            for (int i = 1; i < table.GetLength(0); i++)
                {
                    int temp = SumRows(table,i);
                        if(temp<min)
                            {
                                min=temp;
                                result=i;
                            }
                }
        Console.WriteLine($"{result+1} - строкa с наименьшей суммой элементов ");
    }
int[,] table = new int[4,4];
FillArray(table);
PrintArray(table);
Sum(table); 
MinSumRows(table);