﻿// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Input three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("Second digit of number is -> "+stringNumber[1]);
*/

// 2.  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
    if (stringNumber.Length > 2) 
{
    Console.WriteLine("Third digit of number is -> "+stringNumber[2]);
}
   else
{
    Console.WriteLine("The third digit is missing");
}
*/

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input day: ");
int number = Convert.ToInt32(Console.ReadLine());
  
    if (number > 5) 
{
    Console.WriteLine("Yes");
}
   else
{
    Console.WriteLine("No");
}

