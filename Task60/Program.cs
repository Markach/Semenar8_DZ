// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
void FillArray(int[,,] matrix)
    {
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                        {
                            matrix[i,j,k] = random.Next(70,90);
                        }
                }
        }
    }
void PrintArray(int[,,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            Console.WriteLine("Page N: " + (i+1));//мне удобно так представлять массив (как книга, на странице координаты j и k)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix.GetLength(2); k++)
                        {
                            Console.Write($"({i},{j},{k})" + matrix[i,j,k] + " " );
                        }
                        Console.WriteLine();
                    }
            Console.WriteLine();       
        }  
    }
int[,,] table = new int[2,2,2];
FillArray(table);
PrintArray(table);
// int[] array = new int[table.GetLength(0)*table.GetLength(1)*table.GetLength(2)];
// void OneDimensionalArray(int[]array)//копирую все в 1D матрицу нужного размера
//     {
//         int s =0;
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             for (int k = 0; k < table.GetLength(2); k++)
//                                 {
//                                     array[s]=table[i,j,k] ;
//                                     s++;
//                                 } 
//                         }    
//                 }   
// for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();  
// }    
void SortOneDimensionalArray(int[,,]array)//если нахожу повторяющееся число, меняю его на (максимальное+1), если еще одно--снова макс+1
    {
        int count =0;
        int maxNumber= array[0,0,0];
           for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            for (int k = 0; k < table.GetLength(2); k++)
                                {
                    if(array[i,j,k]> maxNumber)
                        {
                            maxNumber=array[i,j,k];
                        }
                }
for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
            {
                if (array[i]==array[j]) 
                    {
                        maxNumber++;
                        array[j]=maxNumber;
                        count++;
                            if(count>1)
                                {
                                    array[j]=maxNumber; 
                                }
                    }
            }
    } 
for (int i = 0; i < array.Length; i++) 
    {
       Console.Write(array[i]+ " ");
    }
    Console.WriteLine(); 
}
void ThreeDimensionalArray()//снова ложу все в 3D матрицу
    {
        int cou=0;
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            for (int k = 0; k < table.GetLength(2); k++)
                                {
                                    table[i,j,k]=array[cou] ;
                                    cou++;
                                } 
                        }    
                }  
    } 
OneDimensionalArray(array);
SortOneDimensionalArray(array);
ThreeDimensionalArray();
PrintArray(table);