using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IReceiptRepository <R> where R : Receipt
    {
        bool AddReceipt(R receipt);
        void Pay(R receipt);
        int? GetMaxIdReceipt();
    }
}
