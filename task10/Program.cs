
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

*/

int GetNumber(string str)
{
    
while(true)
{
    Console.WriteLine(str);
    int number=Convert.ToInt32(Console.ReadLine());
    int lenght=number.ToString().Length;
if (lenght==3) 
{
   return number;
}
else
{
     Console.WriteLine("Введено не трехзначное число");
     
}
}
}

int result(int second)
{
int result1=second%100/10;
return result1;
}

int number1=GetNumber("Введите трехзначное число");
int resault =result(number1);

Console.WriteLine("Вторая цифра числа: "+resault);
