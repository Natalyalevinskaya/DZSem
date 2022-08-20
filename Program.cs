// Задача 2 Семинар 1
// Написать программу, которая на вход принимает два числа 
// и выдаёт какое число больше, а какое меньше.

Console.Write("Enter numberA : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numberB : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine(" A more B");
}
else if (numberA < numberB)   // сочетание: else if является продолжением проверки if.
{
    Console.WriteLine(" B more A");
}
else
{
    Console.WriteLine("A equals B");
}


//Задача 4: 
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.Write("Enter first number :");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number :");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number :");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

 if (max < numberB)
 max = numberB;

if (max < numberC)
max = numberC;

Console.WriteLine($"max number = {max}");


//Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//делится ли оно на два без остатка.

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) 
{                             
    Console.Write(number + " is Even Number"); 
}
else
{                            //нечётное число
    Console.Write(number + " is Odd number"); 
}                                              



//Задача 8: 
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
int num = 2;
for (int i=0; i<30; i++)
{
    Console.WriteLine(num);
    num = (-(~num)); num = (-(~num)); // побитовое отрицание, всё что "НЕ"
}
