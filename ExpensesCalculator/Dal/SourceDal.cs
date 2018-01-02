using System.Collections.Generic;
using System.Linq;

namespace ExpensesCalculator.Dal
{
    public class SourceDal
    {
        public Dictionary<string, Source> GetAllSources()
        {
            using (var cn = new TransactionsDataContext())
            {
                return cn.Sources.ToDictionary(s => s.NAME);
            }
        }

        public void Insert(List<Source> sources)
        {
            using (var cn = new TransactionsDataContext())
            {
                cn.Sources.InsertAllOnSubmit(sources);
                cn.SubmitChanges();
            }
        }
    }
}
