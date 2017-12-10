using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class AccountRepository : IAccountRepository<Account>
    {
        #region Singleton
        //private static AccountRepository instace;

        //public static AccountRepository Instace
        //{ get
        //    {
        //        if (instace == null)
        //            instace = new AccountRepository();
        //        return instace;
        //    }
        //    private set => instace = value;
        //}
        #endregion
        private CFMEntities db =  CFMEntities.Instance;
        public bool AddAccount(Account acc)
        {
            try
            {
                db.Accounts.Add(acc);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckUser(Account acc)
        {
            var user = db.Accounts.FirstOrDefault(c => c.userName == acc.userName
               && c.passWord == acc.passWord);
            if (user != null)
                return true;
            return false;
        }

        public bool DeleteAccount(string user)
        {
            Account account = GetAccountByUsername(user);
            try
            {
                db.Accounts.Remove(account);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool EditAccount(Account acc)
        {
            Account originalAcc = GetAccountByUsername(acc.userName);
            try
            {
                db.Entry(originalAcc).CurrentValues.SetValues(acc);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Account GetAccountByUsername(string username)
        {
            return (from a in db.Accounts
                    where a.userName == username
                    select a).FirstOrDefault();
        }

        public IEnumerable<Account> GetAll()
        {
            return db.Accounts.ToList();
        }
        /// <summary>
        /// Reset password to '1'
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool ResetPassWd(string username)
        {
            Account originalAccount = GetAccountByUsername(username);
            Account account = GetAccountByUsername(username);
            try
            {
                account.passWord = "1";
                db.Entry(originalAccount).CurrentValues.SetValues(account);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
