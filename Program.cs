//  Напишите программу, которая принимает 
//  на вход трёхзначное число и на выходе 
//  показывает вторую цифру этого числа.

/*
int Third(int number){
    return number % 10;
}
Console.Write("Input a three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Third number is {Third(num)}");
*/

// Напишите программу, которая выводит третью
//  цифру заданного числа или сообщает, 
//  что третьей цифры нет.

/*
void IsThird(int number){
    if (number >=100){
        while (number > 999){
            number = number / 10;
        }
        number = number % 10;
        Console.WriteLine ($"Third number is {number}");
    }
    else
        Console.WriteLine("This number doesn't have third number");
}
Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
IsThird(num);
*/

// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

/*
bool Week(int day){
    return day == 6 || day == 7;
}
Console.Write("Input number of a day ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Is day {day} a weekend? {Week(day)}");
*/