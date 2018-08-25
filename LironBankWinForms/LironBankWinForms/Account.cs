using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LironBankWinForms
{
    class Account
    {
        double money = 0;
        public string Username;
        string password;
        public Account(string Username, string password)
        {
            this.Username = Username;
            this.password = password;
            money = 100;
        }

        public bool CheckLogin(string username, string password)
        {
            if (this.Username == username && this.password == password)
            {
                return true;
            }
            return false;
        }

        public bool Deposit(int amount)
        {
            if (amount < 0)
            {
                return false;
            }
            money += amount;
            return true;
        }


        public bool Withdrawl(int amount)
        {
            if (amount > money)
            {
                return false;
            }
            else
            {
                money = money - amount;
            }
            return false;
        }


    }
}
