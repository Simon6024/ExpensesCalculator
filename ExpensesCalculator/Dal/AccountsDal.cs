using System.Collections.Generic;
using System.Linq;

namespace ExpensesCalculator.Dal
{
    public class AccountsDal
    {
        public List<Account> GetAllAccounts()
        {
            using (var cn = new TransactionsDataContext())
            {
                return cn.Accounts.ToList();
            }
        }
    }
}