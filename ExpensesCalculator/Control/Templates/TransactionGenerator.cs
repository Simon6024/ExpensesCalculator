using System;
using System.Collections.Generic;

namespace ExpensesCalculator.Control
{
    public abstract class TransactionGenerator
    {
        public abstract List<Transaction> GetTransactions(List<String[]> transaction, Account account);
    }
}