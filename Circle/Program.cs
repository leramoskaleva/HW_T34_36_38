﻿// За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
//Напишите консольную программу, в которую пользователь вводит 
//сумму вклада и количество месяцев. А банк вычисляет конечную сумму
// вклада с учетом начисления процентов за каждый месяц.

//Console.Write ("Введите сумму вклада ");
//decimal sum = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Введите количество месяцев ");
//int period = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= period; i++)
//{
//    sum += sum * 0.07M;
//}
//Console.WriteLine ($"После {period} месяцев сумма вклада равна {sum}");

// Перепишите предыдущую программу, только вместо цикла for 
// используйте цикл while.



//Console.Write ("Введите сумму вклада ");
//decimal sum = Convert.ToDecimal(Console.ReadLine());

//Console.Write("Введите количество месяцев ");
//int period = Convert.ToInt32(Console.ReadLine());
//int i = period;

//while (i > 0)
//{
//    sum += sum * 0.07M;
//    i--;
//}
//Console.WriteLine ($"После {period} месяцев сумма вклада равна {sum}");

//Напишите программу, которая выводит на консоль таблицу умножения

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.Write($"{i * j} \t");
//    }
//    Console.WriteLine();
//}

//Напишите программу, в которую пользователь вводит два числа 
//и выводит результат их умножения. При этом программа должны 
//запрашивать у пользователя ввод чисел, пока оба вводимых числа 
//не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся
// больше 10 или меньше 0, то программа должна вывести пользователю 
//о том, что введенные числа недопустимы, и повторно запросить у 
//пользователя ввод двух чисел. Если введенные числа принадлежат
// диапазону от 0 до 10, то программа выводит результат умножения.

while(true)
{
Console.Write("Введите число от 2 до 9: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число от 2 до 9: ");
int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 >= 1 && number1 <= 10 && number2 >= 1 && number2 <= 10)
    {
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
        break;
    }
    else
    {
        Console.WriteLine("Числа должны быть в диапазоне от 2 до 9");
    }
}