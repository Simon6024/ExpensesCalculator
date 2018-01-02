using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpensesCalculator.Control
{

    public class Desjardins : TransactionGenerator
    {
        public override List<Transaction> GetTransactions(List<String[]> transaction, Account account)
        {
            var trxs = new List<Transaction>();

            foreach (var trx in transaction.Skip(1))//Skipping one because of the header
            {
                decimal amount = 0;
                if (Decimal.TryParse(trx[8], out decimal positive))
                {
                    amount += positive;
                }
                if (Decimal.TryParse(trx[7], out decimal negative))
                {
                    amount -= negative;
                }

                trxs.Add(new Transaction()
                {
                    ACCOUNT_FK = account.ACCOUNT
                    ,
                    DATE = DateTime.Parse(trx[3].Replace("\"", ""))
                    ,
                    COMMENT = null
                    ,
                    SOURCE_FK = trx[5].Replace("\"", "")
                    ,
                    AMOUNT = amount
                });
            }

            return trxs;
        }
    }
}