using System;

namespace OperationSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
            int operationNumber = Convert.ToInt32(Console.ReadLine());

            switch (operationNumber)
            {
                case 1:
                    Console.WriteLine("Вы выбрали операцию: Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали операцию: Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали операцию: Умножение");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
        }
    }
}
