using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class AccountService : IAccountService<Account>
    {
        private IAccountRepository<Account> _repository;

        public AccountService(IAccountRepository<Account> repository)
        {
            this._repository = repository;
        }
        public bool AddAccount_S(Account acc)
        {
            if (_repository.AddAccount(acc))
                return true;
            return false;
        }

        public bool CheckUser_S(Account acc)
        {
            if (_repository.CheckUser(acc))
                return true;
            return false;
        }

        public bool DeleteAccount_S(string user)
        {
            if (_repository.DeleteAccount(user))
                return true;
            return false;
        }

        public bool EditAccount_S(Account acc)
        {
            if (_repository.EditAccount(acc))
                return true;
            return false;
        }

        public Account GetAccountByUsername_S(string username)
        {
            return _repository.GetAccountByUsername(username);
        }

        public IEnumerable GetAll_S()
        {
            return _repository.GetAll();
        }

        public bool ResetPassWd_S(string username)
        {
            if (_repository.ResetPassWd(username))
                return true;
            return false;
        }
    }
}
