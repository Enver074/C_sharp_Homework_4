// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число А");
int numbA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число В");
int numbB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {numbA} в степени {numbB} = {Exponentation(numbA)}");

int Exponentation(int number){
    int Exp = Convert.ToInt32(Math.Pow(numbA,numbB));
    return Exp;
}
