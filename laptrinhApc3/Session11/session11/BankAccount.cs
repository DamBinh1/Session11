using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc3.session11
{
    public class BankAccount
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                {
                    balance = value;
                    OnBalanceChanged();
                }
                else
                {
                    Console.WriteLine("So du tai khoan khong the nho hon 0.");
                }
            }
        }

        public event EventHandler BalanceChanged;

        public virtual void OnBalanceChanged()
        {
            BalanceChanged.Invoke(this, EventArgs.Empty);
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Gui tien thanh cong. So du moi: {Balance}");
            }
            else
            {
                Console.WriteLine("So tien gui phai lon hon 0.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Rut tien thanh cong.So du moi: {Balance}");
            }
            else
            {
                Console.WriteLine("So tien rut khong hop le.");
            }
        }
    }
}
