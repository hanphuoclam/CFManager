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
        bool Pay_S(R receipt);
    }
}
