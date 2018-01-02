using System.Linq;
using System;
using ExpensesCalculator.Dal;
using System.Collections.Generic;

namespace ExpensesCalculator.Control
{
    public class FileContentImporter
    {
        private TransactionDal _transactionDal = new TransactionDal();
        private SourceDal _sourceDal = new SourceDal();

        public void Import()
        {
            CsvReader reader = new CsvReader();
            var AllFilesContent = reader.GetAllFilesContent();
            var accounts = new AccountsDal().GetAllAccounts();

            foreach (var content in AllFilesContent)
            {
                var curAcc = accounts.First(a => content.FileName.Contains(a.FILENAME));
                Console.WriteLine($"Importing transactions from file: {content.FileName} for account {curAcc.ACCOUNT}...");
                var t = (TransactionGenerator)Activator.CreateInstance(Type.GetType("ExpensesCalculator.Control." + curAcc.TEMPLATE));
                var trxs = t.GetTransactions(content.Content, curAcc);

                //Filtering out transactions in treated dates
                RemovePreviouslyTreatedTransactions(ref trxs, curAcc);
                Console.WriteLine($"Transactions treated. Count: {trxs.Count}");

                //Add new sources
                Console.WriteLine("Adding new sources...");
                AddSourcesAndCategories(ref trxs);

                //Saving trx
                Console.WriteLine("Saving transactions...");
                _transactionDal.Insert(trxs);

                //Archiving file
                Console.WriteLine($"Done with file : {content.FileName} for account {curAcc.ACCOUNT}...\nArchiving...");
                reader.Archive(content.FileName);
            }
        }

        public void AddSourcesAndCategories(ref List<Transaction> trx)
        {
            var sources = _sourceDal.GetAllSources();
            var newSources = new List<Source>();

            foreach (var t in trx)
            {
                if (sources.ContainsKey(t.SOURCE_FK))
                {
                    sources.TryGetValue(t.SOURCE_FK, out Source source);
                    t.ID_TRX_TYPE_FK = source.ID_TRX_TYPE_FK;
                    t.TYPE_FROM_SOURCE = true;
                }
                else if (!newSources.Any(s => s.NAME == t.SOURCE_FK))
                {
                    newSources.Add(new Source { NAME = t.SOURCE_FK, ID_TRX_TYPE_FK = null });
                }
            }
            Console.WriteLine($"Saving new sources count: {newSources.Count}...");
            _sourceDal.Insert(newSources);
        }

        public void RemovePreviouslyTreatedTransactions(ref List<Transaction> trxs, Account account)
        {
            var i = _transactionDal.GetTrxBoundaries(account);
            trxs.RemoveAll(t => t.DATE <= i.UpperBound && t.DATE >= i.LowerBound);
        }

    }
}