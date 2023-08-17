using laptrinhApc3.session11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc3.session11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            account.BalanceChanged += (sender, e) =>
            {
                Console.WriteLine("So du tai khoan da thay doi.");
            };

            account.Deposit(1000);
            account.Withdraw(500);
        }
    }
}




