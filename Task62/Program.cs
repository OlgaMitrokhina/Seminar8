// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int n = 4;
int[,] matr = new int[n, n];

void FillArray(int[,] arr)
{
    int count = 1;
    for (int i = 0; i < n - 2; i++)
    {
        for (int j = i; j < n - i; j++) matr[i, j] = count++;
        for (int k = i + 1; k < n - i; k++) matr[k, n - 1 - i] = count++;
        for (int j = n - i - 2; j >= i; j--) matr[n - 1 - i, j] = count++;
        for (int k = n - 2 - i; k > i; k--) matr[k, i] = count++;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            string str = string.Format("{0}", arr[i, j]);
            Console.Write($"{str} {"\t"}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

FillArray(matr);
PrintArray(matr);