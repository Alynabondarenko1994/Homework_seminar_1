/*
Напишите программу , которая на вход принимает три числа, и выдает макисмальное из этих чисел
*/



Console.WriteLine("Введите для сравнения три числа:");

double number1=Convert.ToDouble(Console.ReadLine());
double number2=Convert.ToDouble(Console.ReadLine());
double number3=Convert.ToDouble(Console.ReadLine());

double max=number1;
if (max<number2) max=number2;
if (max<number3) max=number3;

Console.WriteLine("Наибольшее число:"+ max);