using System;
using System.Collections.Generic;
using System.Linq;
using ExpensesCalculator.Entities;

namespace ExpensesCalculator.Dal
{
    public class TransactionDal
    {
        public List<Transaction> GetAllTransaction()
        {
            using (var cn = new TransactionsDataContext())
            {
                return cn.Transactions.ToList();
            }
        }

        public Interval GetTrxBoundaries(Account account)
        {
            var interval = new Interval();
            using (var cn = new TransactionsDataContext())
            {
                if (cn.Transactions.Where(t => t.ACCOUNT_FK.Equals(account.ACCOUNT)).Any())
                {
                    interval.UpperBound = cn.Transactions.Where(t => t.ACCOUNT_FK.Equals(account.ACCOUNT)).Max(t => t.DATE);
                    interval.LowerBound = cn.Transactions.Where(t => t.ACCOUNT_FK.Equals(account.ACCOUNT)).Min(t => t.DATE);
                }
                else
                {
                    interval.UpperBound = DateTime.Today.AddDays(1);
                    interval.LowerBound = DateTime.Today.AddDays(1);
                }
            }
            return interval;
        }

        public void Insert(List<Transaction> transactions)
        {
            using (var cn = new TransactionsDataContext())
            {
                cn.Transactions.InsertAllOnSubmit(transactions);
                cn.SubmitChanges();
            }
        }
    }
}
