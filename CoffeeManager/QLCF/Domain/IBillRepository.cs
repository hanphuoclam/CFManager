using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IBillRepository <B> where B : Bill
    {
        IEnumerable<B> GetAll();
        B GetBillById(int id);
        bool AddBill(B bill);
        bool CheckOut(B bill);
        int GetUncheckBillByIdTable(int idtable);
    }
}
