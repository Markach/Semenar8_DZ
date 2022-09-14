// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] FillArray()
    {
        int[,] table = new int[2,2];
        Random random = new Random();
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            table[i,j] = random.Next(1,10);
                        }
                }
    return table;
    }
void PrintArray(int[,] table)
    {
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j] + " " );
                }
            Console.WriteLine();
        }
    }
// метод для умножения матриц
int[,] Multiplication(int[,] table1, int[,] table2)
    {       
        int[,] result = new int[table1.GetLength(0), table2.GetLength(1)];//заготовка выходной(результирующей) матрицы
//В полученной матрице:количество строк в ней равно числу строк первого множителя, а количество столбцов – числу столбцов второго множителя.
// последовательно умножаем каждую строку первой матрицы на каждый столбец второй. 
        for (int i = 0; i < table1.GetLength(0); i++)
            {
                for (int j = 0; j < table2.GetLength(1); j++)
                    {
                        result [i, j] = 0;
                            for (int k = 0; k < table1.GetLength(0); k++)
                                {
                                    result[i, j] += table1[i, k] * table2[k, j];
                                }
                    }
                }
    return result;
    }
int[,] table = new int[2,2];
int[,]table1 = FillArray();
PrintArray(table1);
Console.WriteLine();
int[,] table2= FillArray();
PrintArray(table2);
int[,] res= Multiplication( table1, table2);
Console.WriteLine("Произведение матриц:");
PrintArray(res);



