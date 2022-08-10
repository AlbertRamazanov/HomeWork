
// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* Console.WriteLine ("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
Console.WriteLine ($" {n1} is the max, {n2} is the minimum");
}
else
{
Console.WriteLine ($"{n2} is the max, {n1} is the minimum");
}
*/

// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* Console.WriteLine ("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine ($"{n1} is the max");
}
else if (n2 > n1 && n2 > n3)
{
     Console.WriteLine ($"{n2} is the max");
}
    else if (n3 > n1 && n3 > n2)
{
     Console.WriteLine ($"{n3} is the max");
}
*/

// 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/* Console.Write ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
{
    Console.Write ($"{number} is an odd number");
}
else 
{
    Console.Write ($"{number} this is an even number");
}
*/

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int current = 1; current <= number; current++ )
     if(current % 2 == 0)
     {
        Console.WriteLine(current);
     }
