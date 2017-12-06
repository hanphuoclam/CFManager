using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IReceiptInfoService <R> where R : ReceiptInfo
    {
        bool AddReceiptInfo_S(R receiptInfo);
        bool DeleteReceiptInfoByIdProduct_S(int idProduct);
        IEnumerable GetReceiptInfoByIdReceipt_S(int idReceipt);
    }
}
