using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repositoy
{
    public class TransactionHeaderRepository
    {
        static Kpop db = Singleton.GetConnection();

        public List<TransactionHeader> GetTransactions()
        {
            return (from TransactionHeader in db.TransactionHeaders select TransactionHeader).ToList();
        }
    }
}