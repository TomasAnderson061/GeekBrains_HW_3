// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Palind(int n){
    int l1=n/10000;
    int l2=n/1000%10;
    int r1=n%10;
    int r2=n/10%10;
    if (l1==r1&&l2==r2)
        Console.WriteLine($"Число {n} является палиндромом");
    else
        Console.WriteLine($"Число {n} не является палиндромом");
}
    Console.WriteLine("Введите N: ");
    int num = Convert.ToInt32(Console.ReadLine());
Palind(num);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Dist3D (int x, int x1, int y, int y1,int z, int z1) {
    double dist = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
    Console.WriteLine(Math.Round(dist,2));
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Расстояние от А({x},{y},{z}) до В({x1},{y1},{z1}) равно:");
Dist3D(x, x1, y, y1, z, z1);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до
// N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubs(int n1){
    for (int i=1; i<=n1; i++)
    Console.WriteLine(i*i*i);
}    
    Console.WriteLine("Введите N: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Таблица кубов от 1 до {num1}:");
 Cubs(num1);

