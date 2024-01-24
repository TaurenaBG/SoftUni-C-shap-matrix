var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];


int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    var rowArry = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rowArry[j];
        }
    }
}
int ROW = 0;
int COL = 0;

int maxSum = int.MinValue;

for(int i = 0;i < matrix.GetLength(0)-1; i++)
{
    for(int j = 0; j < matrix.GetLength(1)-1;j++)
    {
        int currentSum = matrix[i,j] + matrix[i,j+1] + matrix[i+1,j] + matrix[i+1,j+1];

        if(currentSum > maxSum)
        {
            maxSum = currentSum;
            ROW = i;
            COL = j;
            
        }

        

    }
}

Console.WriteLine($"{matrix[ROW, COL]} {matrix[ROW,COL+1]}");
Console.WriteLine($"{matrix[ROW+1, COL]} {matrix[ROW+1,COL+1]}");
Console.WriteLine(maxSum);