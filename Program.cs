Console.WriteLine("HW_2_Task_1");
// Условие задачи:
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

void Task1(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} кратно 7 и 23 одновременно");
    }
    else
    {
        Console.WriteLine($"{num} не кратно 7 и 23 одновременно");
    }
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Task1(number);