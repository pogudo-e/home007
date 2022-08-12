int m = 3;
int n = 4;

double col = 0;
double[,] array = new double[m,n];
string res = "";

for(int i = 0; i < m; i++){
    col = 0;
    for (int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
        col += array[i,j];
    }
    res += string.Format("{0:f1} ", col/m);
    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое кждого столбца: {res}");
