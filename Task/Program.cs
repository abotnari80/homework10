int[] info = new int[] {2, 3, 3, 1};
int[] data = new int[] {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] tmpResult = new int[4];
int[] result = new int[4];
int[] answer = new int[4];

int x = 0;
int y = 0;
int z = 0;

for (int i = 0; i < 4; i++)
{
    x = info[i];
    for (int j = y; j < (x + y); j++)
    {
        tmpResult[i] = (tmpResult[i] * 10) + data[j];
        z++;
    }
    System.Console.WriteLine();
    y = z;
}

int tmp = 0;
int n = 2;

for (int i = 0; i < 4; i++)
{
    if (tmpResult[i] > 0)
    answer[i] = result[i] + answer[i];
    tmp = tmpResult[i] % 10;
    result[i] = tmp * 1;
    while (tmpResult[i] > 0)
    {
        answer[i] = result[i] + answer[i];
        tmp = tmpResult[i] % 10;
        n = n * n;
        result[i] = tmp * n;
    }
}

for (int i = 0; i < 4; i++)
{
    System.Console.Write(answer[i]);
}