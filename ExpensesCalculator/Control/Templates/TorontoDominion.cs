using System;
using System.Collections.Generic;

namespace ExpensesCalculator.Control
{
    public class TorontoDominion : TransactionGenerator
    {
        public override List<Transaction> GetTransactions(List<String[]> transaction, Account account)
        {
            var trxs = new List<Transaction>();

            foreach (var trx in transaction)
            {
                decimal amount = 0;
                if (Decimal.TryParse(trx[3], out decimal positive))
                {
                    amount += positive;
                }
                if (Decimal.TryParse(trx[2], out decimal negative))
                {
                    amount -= negative;
                }

                trxs.Add(new Transaction()
                {
                    ACCOUNT_FK = account.ACCOUNT
                    ,
                    DATE = DateTime.Parse(trx[0])
                    ,
                    COMMENT = null
                    ,
                    SOURCE_FK = trx[1]
                    ,
                    AMOUNT = amount
                });
            }

            return trxs;
        }
    }
}