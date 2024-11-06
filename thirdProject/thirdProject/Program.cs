int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int sum;
for (int i = 0; i < 3; i++)
{
    sum = 0;
    for (int j = 0; j < 3; j++)
    {
        sum += arr[i, j];
    }
    Console.WriteLine(sum);
}
        

Console.ReadKey();