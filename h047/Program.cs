int m = 3;
int n = 4;

double[,] array = new double[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i,j] = Convert.ToDouble(new Random().Next(-99, 100)) / 10;
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
}