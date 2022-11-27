using System;
using System.Text.RegularExpressions;

namespace VerySimpleAuth
{
    class Program
    {

        public static void Main()
        {



            while (true)
            {
                Console.WriteLine("Пройдите регистрацию");
                Console.Write("Логин должен состоять из Заглавных, строчных, символов и цифр \nВведите логин: ");
                String login = Console.ReadLine();

                if (Regex.IsMatch(login, @"[A-Z]") && Regex.IsMatch(login, @"[a-z]") && Regex.IsMatch(login, @"[0-9]") && Regex.IsMatch(login, @"[!-*]"))
                {
                    Console.WriteLine("Complete");

                }
                else
                {
                    Console.WriteLine("incorrect login");
                    continue;
                }
                if (login.Length < 9 && login.Length > 3)
                {
                    Console.WriteLine("Недопустимое количество символов в логине - нужно больше 3 и менее 9!");
                }

                Console.Write("Введите пароль: ");
                String pass = Console.ReadLine();
                if (pass.Length < 3 && pass.Length > 9)
                {
                    Console.WriteLine("Недопустимое количество символов в пароле - нужно больше 3 м менее 9!");
                }
                if (login == pass)
                {
                    Console.WriteLine("Логин и пароль совпадают, измените данные");
                    continue;
                }
                else
                {
                    Console.WriteLine("Регистрация прошла успешно!");

                }
                break;

            }
        }
    }

}