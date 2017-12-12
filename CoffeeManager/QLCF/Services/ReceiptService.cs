using System;
using System.Collections;
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

        public IEnumerable GetAll_S()
        {
            return _repository.GetAll();
        }

        public int? GetMaxIdReceipt_S()
        {
            return _repository.GetMaxIdReceipt();
        }

        public IEnumerable GetReceiptByDate_S(DateTime dateFrom, DateTime dateTo)
        {
            return _repository.GetReceiptByDate(dateFrom, dateTo);
        }

        public void Pay_S(Receipt receipt)
        {
            _repository.Pay(receipt);
        }
    }
}
