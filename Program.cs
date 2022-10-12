// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// Console.WriteLine("Введите число А");
// int numbA = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число В");
// int numbB = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Число {numbA} в степени {numbB} = {Exponentation(numbA)}");

// int Exponentation(int number){
//     int Exp = Convert.ToInt32(Math.Pow(numbA,numbB));
//     return Exp;
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine(GetSum(numb));

int GetSum(int i){
    int sum = 0;
    while(i > 0){
    sum += i % 10;
    i /= 10;}
    return sum;
    }    
        