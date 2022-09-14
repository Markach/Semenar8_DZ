// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void FillArray(int[,] table)
    {
    Random random = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i,j] = random.Next(10,100);
                }
        }
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

void SortRows (int[,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    for (int x = 0; x < table.GetLength(1)-1; x++)
                        {
                            if(table[i,x]<table[i,x+1]) //если первый элемент меньше следующего, меняем местами
                                {
                                    int temp= table[i,x+1];
                                    table[i,x+1]= table[i,x];
                                    table[i,x]=temp;
                                }
                        }  
                }
        }
}
int[,] table = new int[3,4];
FillArray(table);
PrintArray(table);
Console.WriteLine();
SortRows(table);
PrintArray(table);
