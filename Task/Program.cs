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
            int accNumInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО: ");
            string accFullName = Console.ReadLine();
            Console.Write("Введите баланс аккаунта: ");
            double accBalance = Convert.ToDouble(Console.ReadLine());
            BankAccount<int> bankAccInt = new BankAccount<int>(accNumInt, accFullName, accBalance);

            BankAccount<string> bankAccStr = new BankAccount<string>();
            bankAccStr.Input();



            BankAccount<string> bankAccStr2 = new BankAccount<string>();
            bankAccStr2.setAccNumber(bankAccStr.getAccNumber() + "test");
            bankAccStr2.setAccName(bankAccStr.getAccName() + "test");
            bankAccStr2.setAccBalance(bankAccStr.getAccBalance() / 2);

            Console.WriteLine();
            Console.WriteLine(bankAccInt.GetInfo());
            Console.WriteLine(bankAccStr.GetInfo());
            Console.WriteLine(bankAccStr2.GetInfo());

            Console.ReadKey();






        }
    }
}
