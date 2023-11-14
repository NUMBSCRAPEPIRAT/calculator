
using System;
class Calculator
{
    public delegate int Calculate(int x, int y);
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }


public delegate int Calculate_2(int x, int y);

        static int Multiply(int x, int y)
    {
        return x * y;
    }
    static int Division(int x, int y){
        return x/y;
    }
     static int Add_1(int x, int y)
    {
        return x + y;
    }

    static int Subtract_2(int x, int y)
    {
        return x - y;
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка в формате ввода числа.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Деление на 0 невозможно");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Неверная операция.");
        }
        catch (Exception)
        {
            Console.WriteLine("Произошла ошибка.");
        }
    }
}





