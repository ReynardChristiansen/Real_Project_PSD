using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repositoy
{
    public class Singleton
    {
        private static Kpop db = null;
        private Singleton()
        {

        }

        public static Kpop GetConnection()
        {
            if (db == null)
            {
                db = new Kpop();
            }
            return db;
        }
    }
}