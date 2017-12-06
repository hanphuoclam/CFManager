using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IAccountService <Ac> where Ac : Account
    {
        bool CheckUser_S(Ac acc);
        bool AddAccount_S(Ac acc);
        bool EditAccount_S(Ac acc);
        bool DeleteAccount_S(string user);
        Ac GetAccountByUsername_S(string username);
        bool ResetPassWd_S(string username);
        IEnumerable GetAll_S();
    }
}
