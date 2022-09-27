// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


int[,,] Create3DMatrix(int m1, int n1, int l1) 
{
    int[,,] matrix3D = new int[m1, n1, l1];
    for(int i = 0; i < m1; i++) 
    {
        for(int j = 0; j < n1; j++) 
        {
            for(int k = 0; k < l1; k++) 
            {
                matrix3D[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix3D;
}

void Print3dMatrix(int[,,] matrix3DPrint) 
{
        for(int i = 0; i < matrix3DPrint.GetLength(0); i++) 
        {
        for(int j = 0; j < matrix3DPrint.GetLength(1); j++)
         {
            for(int k = 0; k < matrix3DPrint.GetLength(2); k++) 
            {
                Console.Write(string.Join(" ", matrix3DPrint[i, j, k]) + " (" + i + ", " + j + ", " + k + ")" + "\t");
            }
        }
        Console.WriteLine();
    }
}
int m = 2;
int n = 2;
int l = 2;
int[,,] matrix3D = Create3DMatrix(m, n, l);

Print3dMatrix(matrix3D);

