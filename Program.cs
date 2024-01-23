// Console.WriteLine("HW_2_Task_1");
// // Условие задачи:
// // Напишите программу, которая принимает на вход число 
// // и проверяет, кратно ли оно одновременно 7 и 23.

// void Task1(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine($"{num} кратно 7 и 23 одновременно");
//     }
//     else
//     {
//         Console.WriteLine($"{num} не кратно 7 и 23 одновременно");
//     }
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Task1(number);

// Console.WriteLine("HW_2_Task_2");
// // Условие задачи:
// // Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// // в которой находится эта точка.

// void Task2(int X, int Y)
// {
//     if (X > 0 && Y > 0)
//     {
//         Console.WriteLine("I координатная четверть");
//     }
//     if (X < 0 && Y > 0)
//     {
//         Console.WriteLine("II координатная четверть");
//     }
//     if (X < 0 && Y < 0)
//     {
//         Console.WriteLine("III координатная четверть");
//     }
//     if (X > 0 && Y < 0)
//     {
//         Console.WriteLine("IV координатная четверть");
//     }
// }
// Console.WriteLine("Input X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// Task2(X, Y);

Console.WriteLine("HW_2_Task_3");

// Условие задачи:
// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.

void Task3(int num)
{
    int first = num / 10;
    int second = num % 10;
    if (first > second)
    {
        Console.WriteLine($"Рандомное число {num}. {first} > {second}.");
    }
    else
    {
        Console.WriteLine($"Рандомное число {num}. {second} > {first}.");
    }
}
int num = new Random().Next(10, 99 + 1);
Task3(num);