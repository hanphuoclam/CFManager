using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IAccountRepository <Ac> where Ac : Account
    {
        bool CheckUser(Ac acc);
        bool AddAccount(Ac acc);
        bool EditAccount(Ac acc);
        bool DeleteAccount(string user);
        Ac GetAccountByUsername(string username);
        bool ResetPassWd(string username);
        IEnumerable<Ac> GetAll();
    }
}
