using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float currencyDollar = 83, currencyEuro = 93, currencyDollarToEuro = 1.12f;
            float rubBalance = 92745f;
            float dollarBalance = 3471f;
            float euroBalance = 734f;
            bool isExit = false;
            char userInput;
            float transferAmount;

            while (!isExit)
            {
                Console.WriteLine("Выберите, куда хотите сконвертировать валюту:" +
                                   "\n---------------------------------------------" +
                                   "\n1 - Рубли => Доллары" +
                                   "\n2 - Рубли => Евро" +
                                   "\n---------------------------------------------" +
                                   "\n3 - Доллары => Рубли" +
                                   "\n4 - Доллары => Евро" +
                                   "\n---------------------------------------------" +
                                   "\n5 - Евро => Рубли" +
                                   "\n6 - Евро => Доллары" +
                                   "\n-------------------Баланс--------------------" +
                                   "\nРубли: " + rubBalance +
                                   "\nДоллары: " + dollarBalance +
                                   "\nЕвро: " + euroBalance +
                                   "\n---------------------------------------------");
                userInput = Console.ReadKey().KeyChar;
                Console.Clear();

                Console.Write("Введите сумму перевода: ");
                transferAmount = Convert.ToSingle(Console.ReadLine());

                switch (userInput)
                {
                    case '1':
                        if (transferAmount <= rubBalance)
                        {
                            rubBalance -= transferAmount;
                            dollarBalance += transferAmount / currencyDollar;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    case '2':
                        if (transferAmount <= rubBalance)
                        {
                            rubBalance -= transferAmount;
                            euroBalance += transferAmount / currencyEuro;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    case '3':
                        if (transferAmount <= dollarBalance)
                        {
                            dollarBalance -= transferAmount;
                            rubBalance += transferAmount * currencyDollar;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    case '4':
                        if (transferAmount <= dollarBalance)
                        {
                            dollarBalance -= transferAmount;
                            euroBalance += transferAmount / currencyDollarToEuro;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    case '5':
                        if (transferAmount <= euroBalance)
                        {
                            euroBalance -= transferAmount;
                            rubBalance += transferAmount * currencyEuro;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    case '6':
                        if (transferAmount <= euroBalance)
                        {
                            euroBalance -= transferAmount;
                            dollarBalance += transferAmount * currencyDollarToEuro;
                            Console.WriteLine("Успешно!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств!");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;
                }

                Console.Write("Продолжить? (q - Выход)");
                userInput = Console.ReadKey().KeyChar;

                if (userInput == 'q' || userInput == 'й')
                    isExit = true;

                Console.Clear();
            }

            Console.WriteLine("\n-------------------Баланс--------------------" +
                              "\nРубли: " + rubBalance +
                              "\nДоллары: " + dollarBalance +
                              "\nЕвро: " + euroBalance +
                              "\n---------------------------------------------");
            Console.WriteLine("Выход...");
        }
    }
}