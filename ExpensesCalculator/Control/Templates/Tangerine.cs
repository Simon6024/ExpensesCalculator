using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpensesCalculator.Control
{
    /*Date,Transaction,Name,Memo,Amount*/
    public class Tangerine : TransactionGenerator
    {
        public override List<Transaction> GetTransactions(List<String[]> transaction, Account account)
        {
            var trxs = new List<Transaction>();

            foreach (var trx in transaction.Skip(1))//Skipping one because of the header
            {
                trxs.Add(new Transaction()
                {
                    ACCOUNT_FK = account.ACCOUNT
                    ,
                    DATE = DateTime.Parse(trx[0])
                    ,
                    COMMENT = trx[2]
                    ,
                    SOURCE_FK = trx[3]
                    ,
                    AMOUNT = Decimal.Parse(trx[4])
                });
            }

            return trxs;
        }
    }
}