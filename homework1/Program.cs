/*
Напишите код, который на вход принимает два числа и выдает. какое число большее, а какое меньшее
*/

Console.WriteLine("Введите для сравнения два числа:");

int number1=Convert.ToInt32(Console.ReadLine());
int number2=Convert.ToInt32(Console.ReadLine());

int max=number1;
if (max<number2) max=number2;
Console.WriteLine("Максимальное число:"+ max);
