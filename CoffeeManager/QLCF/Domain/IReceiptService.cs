using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IReceiptService <R> where R : Receipt
    {
        bool AddReceipt_S(R receipt);
        void Pay_S(R receipt);
        int? GetMaxIdReceipt_S();
        IEnumerable GetAll_S();
        IEnumerable GetReceiptByDate_S(DateTime dateFrom, DateTime dateTo);
    }
}
