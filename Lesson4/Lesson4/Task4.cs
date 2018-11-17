using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Илья Бугров
//4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.


namespace Lesson4
{
    struct Account
    {
        string login;
        string password;

        public Account(string log, string pass)
        {
            login = log;
            password = pass;
        }

        public bool Validation(string log, string pass)
        {
            return log == login && pass == password;
        }

    }

    partial class Program
    {
        static void Task4()
        {
            string[,] accounts = AccRead("C:\\Data\\Logins.txt", "C:\\Data\\Passwords.txt");
            Account acc = new Account(accounts[0, 0], accounts[0,1]);
            if (acc.Validation("root", "GeekBrains"))
            {
                Console.WriteLine("Вы успешно вошли в систему!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Неверные данные.");
                Console.ReadKey();
            }
        } 

        static string[,] AccRead(string fileNameLog, string fileNamePass)
        {
            int logCount = File.ReadAllLines(fileNameLog).Length;
            int passCount = File.ReadAllLines(fileNamePass).Length;
            StreamReader srLog = new StreamReader(fileNameLog);
            StreamReader srPass = new StreamReader(fileNamePass);
            {
                if (logCount == passCount)
                {
                    string[,] accounts = new string[logCount, 1];
                    for (int i = 0; i <= logCount; i++)
                    {
                        accounts[i, 0] = srLog.ReadLine();
                        accounts[i, 1] = srPass.ReadLine();
                    }
                    srLog.Close();
                    srPass.Close();
                    return accounts;
                }
                else
                {
                    throw new ArgumentException("Количество логинов и паролей в файлах не совпадает.");
                }
            }
        }
    }
}
