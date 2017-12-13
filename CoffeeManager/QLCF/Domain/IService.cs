using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IService
    {
        bool Add_S(object obj);
        bool Update_S(object obj);
        bool Delete_S(object obj);
        IEnumerable GetAll_S();
    }
}
