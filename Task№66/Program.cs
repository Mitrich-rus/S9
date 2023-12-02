// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число:");
int endNum = Convert.ToInt32(Console.ReadLine());

static int SummOfDistance(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + SummOfDistance(start + 1, end);
}

if (endNum < num)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {endNum} до {num} равна "+SummOfDistance(endNum, num));
}
if (endNum > num)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {num} до {endNum} равна "+SummOfDistance(num, endNum));
}
else Console.WriteLine($"Сумма натуральных элементов в промежутке от {num} до {endNum}  равна 0");