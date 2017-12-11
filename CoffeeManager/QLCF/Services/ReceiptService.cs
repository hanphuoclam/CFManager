using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class ReceiptService : IReceiptService<Receipt>
    {
        private IReceiptRepository<Receipt> _repository;
        public ReceiptService(IReceiptRepository<Receipt> repository)
        {
            this._repository = repository;
        }
        public bool AddReceipt_S(Receipt receipt)
        {
            if (_repository.AddReceipt(receipt))
                return true;
            return false;
        }

        public int? GetMaxIdReceipt_S()
        {
            return _repository.GetMaxIdReceipt();
        }

        public void Pay_S(Receipt receipt)
        {
            _repository.Pay(receipt);
        }
    }
}
