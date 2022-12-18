// Задача 4: Напишите программу, которая принимает на входтри числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("ВВедите первое число = ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("ВВедите второе число = ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("ВВедите третье число = ");
int num3 = int.Parse(Console.ReadLine());

 if (num1 >= num2)

 {
    if (num3 >= num1)
    {
       Console.WriteLine("Максимальное равно = " + num3);
    }
    else
    {
       Console.WriteLine("Максимальное равно = " + num1);
    }
 }
 else
 {
    if (num3 >= num2)
    {
       Console.WriteLine("Максимальное равно = " + num3);
    }
    else
    {
       Console.WriteLine("Максимальное равно = " + num2);
    }
 }