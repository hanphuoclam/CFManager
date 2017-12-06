using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;
using QLCF.Domain.Validation;
using QLCF.Repository;

namespace QLCF.Services
{
    public class AccountService : IAccountService<Account>
    {
        private IAccountRepository<Account> _repository;
        private IValidationDictionary _validation;

        public AccountService(IValidationDictionary validation ,IAccountRepository<Account> repository)
        {
            this._validation = validation;
            this._repository = repository;
        }
        public AccountService(IValidationDictionary validation) : this(validation,new AccountRepository()) { }

        public bool ValidationAccount(Account acc)
        {
            _validation.DictionaryClear();
            if (acc.userName.Length <= 0)
                _validation.AddError("username", "Tên đăng nhập rỗng");
            return _validation.IsValid;
        }
        public bool AddAccount_S(Account acc)
        {
            if (_repository.AddAccount(acc))
                return true;
            return false;
        }
        
        public bool CheckUser_S(Account acc)
        {
            if (!ValidationAccount(acc))
                return false;
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
