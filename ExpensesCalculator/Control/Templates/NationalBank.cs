﻿using System;
using System.Collections.Generic;

namespace ExpensesCalculator.Control
{

    public class NationalBank : TransactionGenerator
    {
        public override List<Transaction> GetTransactions(List<String[]> transaction, Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}