//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B\

Console.Write("Введите число; A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени; В = ");
int B = Convert.ToInt32(Console.ReadLine());
int AstepB = A;
if (B != 0)
{
for (int i = 1; i < B; i++)
{
    AstepB = AstepB*A;
}
Console.WriteLine($"Число {A}^{B} = {AstepB}");
}
else
{
   Console.WriteLine($"Число {A}^{B} = 1"); 
}
