// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Усложнение. С шагом 0.5

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
Convert.ToDouble (num);
int endNum = 1;

static string PrintNumber(double start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }

    return start + "\t" + PrintNumber(start-0.5, end);
}

Console.WriteLine(PrintNumber(num,endNum));
