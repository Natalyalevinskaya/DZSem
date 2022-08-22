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
if (number % 2 == 0) //если остаток от деления равен нулю, то число чётное.
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


// Семинар 2  
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Write("Input three digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Second number" + stringNumber [1]);

 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
 

Console.Write("Введите трёхзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <= 999)
{
    Console.Write("Последняя цифра :" + Math.Abs (num) % 10);
}
else
{
    Console.Write("Введённое число не трёхзначное");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели,
// и проверяет, является ли этот день выходным.
 Console.Write("Input number of the day: ");

 int day = Convert.ToInt32(Console.ReadLine());

 if (day < 1 || day > 7)
 {
     Console.Write("Incorrect number");
 }
 else
 {
     if (day == 1)
     {
         Console.Write("Monday");
     }
     if (day == 2)
     {
         Console.Write("Tuesday");
     }
     if (day == 3)
     {
        Console.Write("Wednesday");
     }
     if (day == 4)
     {
        Console.Write("Thursday");
     }
     if (day == 5)
     {
        Console.Write("Friday");
     }
     if (day == 6)
     {
        Console.Write("Saturday day off");
    }
    if (day == 7)
    {
        Console.Write("Sunday day off");
    }
 }


