int m = 3;
int n = 4;
Console.Write("Введите номер строки: ");
int h = Convert.ToInt16(Console.ReadLine());
Console.Write("А теперь номер столбца: ");
int w = Convert.ToInt16(Console.ReadLine());


int[,] array = new int[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
}

if (h <= m && w <= n){  // Пользователь не обязан считать как программист, поэтому считаем с единицы
    Console.WriteLine($"Вот что я нашел: {array[h-1,w-1]}");
}
else {
    Console.WriteLine($"{h} {w} -> в данном массиве нет таких координат");
}