// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Input five digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"The {number} is a palindrome");
  }
  else Console.WriteLine($"The {number} is not a palindrome");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Entered the correct number");
*/

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Length(double x1,  double y1, double z1, double x2,  double y2, double z2)
{
    double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return l;
}
Console.Write("Напишите координату первой точки по оси Х: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату первой точки по оси У: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси Х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси У: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату первой точки по оси Z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Напишите координату второй точки по оси Z: ");
double zB = Convert.ToDouble(Console.ReadLine());
double len = Length (xA, yA, xB, yB, zA, zB);
Console.WriteLine($"Длина отрезка равна {len}");

*/

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите номер: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^3 = " + Math.Pow(i, 3));
}