using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tmp1 = 1, Tmp2 = 1;
            int TaskSelection;
            int UserInput1, UserInput2, UserInput3, UserInput4;
            double Result1 = 0, Result2 = 0;
            Console.WriteLine("1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B." +
                "\n2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A." +
                "\n3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A." +
                "\n4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A." +
                "\n5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A)." +
                "\n6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными" +
                "\n7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида." +
                "\n8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления." +
                "\n9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа." +
                "\n10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321." +
                "\n11. Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных." +
                "\n12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”." +
                "\nВведите номер задачи:");

            TaskSelection = Convert.ToInt32(Console.ReadLine());

            switch (TaskSelection)
            {
                case (1):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    UserInput2 = Convert.ToInt32(Console.ReadLine());
                    Result1 = 1;
                    for (int i = 0; i < UserInput2; i++)
                    {
                        Result1 = Result1 * UserInput1;
                    }
                    Console.WriteLine(Result1);
                    break;
                case (2):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < 1000; i++)
                    {
                        if (i % UserInput1 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case (3):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());

                    while (Tmp1 * Tmp1 < UserInput1)
                    {
                        Tmp1++;
                    }
                    Tmp1--;
                    Console.WriteLine(Tmp1);
                    break;
                case (4):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Tmp1 = UserInput1 - 1;
                    for (int i = 1; i < UserInput1 - 1; i++)
                    {
                        if (UserInput1 % i == 0)
                        {
                            Result1 = i;
                        }
                    }
                    Console.WriteLine(Result1);
                    break;
                case (5):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    UserInput2 = Convert.ToInt32(Console.ReadLine());
                    if (UserInput1 > UserInput2)
                    {
                        Tmp1 = UserInput1;
                        UserInput1 = UserInput2;
                        UserInput2 = Tmp1;
                    }
                    for (int i = UserInput1; i < UserInput2; i++)
                    {
                        if (i % 7 == 0)
                        {
                            Result1 += i;
                        }
                    }
                    Console.WriteLine(Result1);

                    break;
                case (6):
                    Console.Write("Введите число N\nN=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Tmp1 = 1;
                    Tmp2 = 1;
                    for (int i = 0; i < UserInput1; i++)
                    {
                        Result1 = Tmp1 + Tmp2;
                        Tmp1 = Tmp2;
                        Tmp2 = (int)Result1;
                    }
                    Console.WriteLine(Result1);
                    break;
                case (7):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    UserInput2 = Convert.ToInt32(Console.ReadLine());

                    while (UserInput1 != 0 && UserInput2 != 0)
                    {
                        if (UserInput1 > UserInput2)
                        {
                            UserInput1 = UserInput1 % UserInput2;
                        }
                        else if (UserInput1 != 0 && UserInput2 != 0)
                        {
                            UserInput2 = UserInput2 % UserInput1;
                        }
                    }
                    Result1 = UserInput1 + UserInput2;
                    Console.WriteLine(Result1);
                    break;
                case (8):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    int DigitCount1 = (int)Math.Log10(UserInput1) + 1;
                    double MinNumber = 0;
                    double MaxNumber = (int)Math.Pow(10, DigitCount1);
                    double CoubeUserInput = Math.Pow(UserInput1, 1.0 / 3.0);
                    double MidNumber = 0;
                    double Answer = 1;
                   double Inaccuracy = 0.05;
                    
                    while (Answer>Inaccuracy)
                    {
                        MidNumber = (MinNumber + MaxNumber) / 2;

                        if (MidNumber>CoubeUserInput)
                        {
                            MaxNumber = MidNumber;
                        }
                        else
                        {
                            MinNumber = MidNumber;
                        }

                        if (MaxNumber-MinNumber<=Inaccuracy)
                        {
                            Answer = MaxNumber - MinNumber;
                            Console.WriteLine($"Ответ{MidNumber} Погрешность {Answer}");
                        }
                    }

                    break;
                case (9):
                    Console.Write("Введите число \n=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Tmp2 = 0;
                    while (UserInput1>0)
                    {
                        Tmp1 = UserInput1 % 10;
                        if (Tmp1%2!=0)
                        {
                            Tmp2++;
                        }
                        UserInput1 /= 10;
                    }
                    Console.WriteLine(Tmp2);
                    break;
                case (10):
                    Console.Write("Введите число N\nN=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Tmp2 = 0;
                    int DigitCount = (int)Math.Log10(UserInput1) + 1;

                    for (int i = 0; i < DigitCount; i++)
                    {
                        Tmp1 = UserInput1 % 10;
                        UserInput1 /= 10;
                        Console.Write(Tmp1);
                    }
                    break;
                case (11):
                    Console.Write("Введите число N\nN=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    int Chet=0, Nechet=0;
                    for (int i = 1; i <= UserInput1; i++)
                    {
                        Tmp2 = i;
                        while (Tmp2>0)
                        {
                            Tmp1 = Tmp2 % 10;
                            Tmp2 /= 10;
                            if (Tmp1 % 2 == 0)
                            {
                                Chet += Tmp1;
                            }
                            else
                            {
                                Nechet += Tmp1;
                            }
                        }

                        if (Chet>Nechet)
                        {
                            Console.WriteLine(i);
                        }
                        Chet = 0;
                        Nechet = 0;
                    }
                    break;
                case (12):
                    Console.Write("Введите число А\nА=");
                    UserInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    UserInput2 = Convert.ToInt32(Console.ReadLine());

                    DigitCount1 = (int)Math.Log10(UserInput1) + 1;
                    int DigitCount2 = (int)Math.Log10(UserInput2) + 1;

                    for (int i = 0; i < DigitCount1; i++)
                    {
                        Tmp1 =UserInput1 % 10;
                        UserInput1 /= 10;

                        for (int y = 0; y < DigitCount2; y++)
                        {
                            Tmp2 =UserInput2 % 10;
                            UserInput2 /= 10;

                            if (Tmp1==Tmp2)
                            {
                                Result1++;
                            }
                        }
                    }
                    if (Result1>0)
                    {
                        Console.WriteLine("Da");
                    }
                    else
                    {
                        Console.WriteLine("Net");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
