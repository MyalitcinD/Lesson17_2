using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числовой номер аккаунта: ");
            int accNumInt =Convert.ToInt32( Console.ReadLine());
            Console.Write("Введите ФИО: ");
            string accFullName = Console.ReadLine();
            Console.Write("Введите баланс аккаунта: ");
            double accBalance = Convert.ToDouble(Console.ReadLine());
            BankAccount<int> bankAccInt = new BankAccount<int>(accNumInt, accFullName, accBalance);

            Console.Write("Введите строковый номер аккаунта: ");
            string accNumStr = Console.ReadLine();
            Console.Write("Введите ФИО: ");
            accFullName = Console.ReadLine();
            Console.Write("Введите баланс аккаунта: ");
            accBalance = Convert.ToDouble(Console.ReadLine());

            BankAccount<string> bankAccStr = new BankAccount<string>();
            bankAccStr.setAccNumber( accNumStr);
            bankAccStr.setAccName( accFullName);
            bankAccStr.setAccBalance( accBalance);

            Console.WriteLine();
            Console.WriteLine(bankAccInt.GetInfo());
            Console.WriteLine(bankAccStr.GetInfo());

            Console.ReadKey();






        }
    }
}
