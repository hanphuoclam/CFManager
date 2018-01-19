using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IBillInfoService <B> where B : BillInfo
    {
        IEnumerable GetListBillInfoByIdBill_S(int idBill);
        bool AddBillInfo_S(B billInfo);
        bool DeleteBillInfoByIdProduct_S(int idProduct);
        bool UpdateBillInfo_S(BillInfo billInfo);
        B GetBillInfoById_S(int id);
    }
}
