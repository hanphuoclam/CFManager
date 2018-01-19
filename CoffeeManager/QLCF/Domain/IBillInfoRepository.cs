using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IBillInfoRepository <B> where B : BillInfo
    {
        IEnumerable<B> GetListBillInfoByIdBill(int idBill);
        bool AddBillInfo(B billInfo);
        bool DeleteBillInfoByIdProduct(int idProduct);
        bool UpdateBillInfo(BillInfo billInfo);
    }
}
