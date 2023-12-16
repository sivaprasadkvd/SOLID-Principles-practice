using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Open-close- Principle : states that software entities should be open for extension but not for modification

namespace solid_principles_practice
{
    internal class Accountdup
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public double balance { get; set; }

        public double calculateInterest(string accountType)
        {
            if (accountType == "Saving")
            {
                return balance * 0.3;
            }
            else                                 
            {
                return balance * 0.5;
            }                                      //here , inserting one more elseif{} will voilate
                                                   // the open closed principles becouse you are modifing the class 
                                                   // rather than extending
        }
    }


    public class Account
    {

        public string Name { get; set; }

        public string Address { get; set; }

        public double balance { get; set; }


    }

    interface IAccount
    {
        double calculateInterest(Account account);
    }

    public class savingAccount : IAccount
    {
        public double calculateInterest(Account account)
        {
            return account.balance * 0.3;
        }
    }

    public class currentAccount: IAccount
    {
        public double calculateInterest(Account account)
        {
            return account.balance * 0.7;
        }
    }
}

