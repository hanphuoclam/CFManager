using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IBillService <B> where B : Bill
    {
        IEnumerable GetAll_S();
        B GetBillById_S(int id);
        bool AddBill_S(B bill);
        bool CheckOut_S(B bill);
        int GetUncheckBillByIdTable_S(int idtable);
    }
}
