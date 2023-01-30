// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// Например
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

// if (max < b)
// {
//   max = b;
// }
// else 
// {
//     max = a;
// }

// if (max<c)
// {
//     max = c;
//     Console.WriteLine($"Максимальное число {max}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число {max}");
// }


// Семён ради всего святого распишите, как эту задачу можно было сделать изящней и компактней. Заранее благодарю

if (max < b)
{
    max =b;
}
else if (max < c)
{
    max = c;
    Console.WriteLine($"Максимальное число {max}");
}
else 
{
    Console.WriteLine($"Максимальное число {max}");
}

// Вроде сделал. Тяжело быть тупым конечно.