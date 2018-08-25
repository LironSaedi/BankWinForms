using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LironBankWinForms
{
    class Bank
    {
        List<Account> accounts = new List<Account>();
        Account loggedInAccount;
       
        public Bank()
        {
            accounts.Add(new Account("Corban", "Kester"));
            accounts.Add(new Account("Lester", "Wilson"));
            accounts.Add(new Account("Luther", "Davis"));
            accounts.Add(new Account("Alexander", "Jhonson"));
            accounts.Add(new Account("Boyd", "Singleton"));
            accounts.Add(new Account("L", "S"));
            accounts.Add(new Account("apple", "banana"));
        }

        public bool Login(string username,string password)
        {
            for(int i = 0; i < accounts.Count; i ++)
            {
                if (accounts[i].CheckLogin(username, password))
                {   
                    loggedInAccount = accounts[i];

                    return true;
                }
                
            }
            return false;
        }
    }

}
