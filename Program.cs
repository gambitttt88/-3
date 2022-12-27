/*Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 2)} ");
}*/

/*Console.WriteLine("Введите координату Х точки1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine($"Расстояние между точками: {res:f2}");*/

/*Задача 1
Console.WriteLine("Введите любое 5-ти значное число");
int number = int.Parse(Console.ReadLine()!);
string Num = Convert.ToString(number);
if(Num.Length != 5)
{
    Console.Write($"Вы ввели не верное число, введите 5-ти значное число");
} 

if((Num[0] == Num[4]) && (Num[1] == Num[3]))
{
    Console.Write($"Введенное число является полиндромом");
}
if((Num[0] != Num[4]) && (Num[1] != Num[3]))
{
    Console.Write($"Введенное число НЕ является полиндромом, введите другое число");
}*/


/*Задача 2
Console.WriteLine("Введите координату Х точки1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки1: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки2: ");
int zb = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {res:f2}");*/


/*Задача 3*/
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
}