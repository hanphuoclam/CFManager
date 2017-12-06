using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IReceiptInfoRepository <R> where R : ReceiptInfo
    {
        bool AddReceiptInfo(R receiptInfo);
        bool DeleteReceiptInfoByIdProduct(int idProduct);
        IEnumerable<R> GetReceiptInfoByIdReceipt(int idReceipt);
    }
}
