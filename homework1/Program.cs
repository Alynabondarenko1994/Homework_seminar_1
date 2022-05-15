/*
Напишите код, который на вход принимает два числа и выдает. какое число большее, а какое меньшее
*/

Console.WriteLine("Введите для сравнения два числа:");

double number1=Convert.ToDouble(Console.ReadLine());
double number2=Convert.ToDouble(Console.ReadLine());

double max=number1;
if (max<number2) max=number2;
Console.WriteLine("Наибольшее число:"+ max);
