using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Repositoy
{
    public class CustomerRepository
    {
        static Kpop db = Singleton.GetConnection();

        public static void Save()
        {
            db.SaveChanges();
        }

        public static void Add(Customer x)
        {
            db.Customers.Add(x);
            db.SaveChanges();
        }

        public static void Remove(Customer x)
        {
            db.Customers.Remove(x);
            db.SaveChanges();
        }


        public static Customer FindEmail(string email)
        {
            return (from user in db.Customers where user.CustomerEmail == email select user).FirstOrDefault();
        }

        public static Customer Find_Email_Password(string email, string password)
        {
            return (from user in db.Customers where user.CustomerEmail == email && user.CustomerPassword == password select user).FirstOrDefault();
        }

        public static int NextID()
        {
            if (db.Customers.Count() == 0)
                return 0;
            return db.Customers.Max(x => x.CustomerID) + 1;
        }
    }
}