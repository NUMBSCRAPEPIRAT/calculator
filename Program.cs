using System;

class Calculator
{
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
                        throw new DivideByZeroException("Деление на ноль невозможно.");
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Неверная операция.");
            }

            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка в формате ввода числа.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Произошла ошибка.");
        }
    }
}
