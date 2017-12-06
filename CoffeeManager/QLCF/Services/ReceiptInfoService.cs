using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class ReceiptInfoService : IReceiptInfoService<ReceiptInfo>
    {
        private IReceiptInfoRepository<ReceiptInfo> _repository;

        public ReceiptInfoService(IReceiptInfoRepository<ReceiptInfo> repository)
        {
            this._repository = repository;
        }
        public bool AddReceiptInfo_S(ReceiptInfo receiptInfo)
        {
            if (_repository.AddReceiptInfo(receiptInfo))
                return true;
            return false;
        }

        public bool DeleteReceiptInfoByIdProduct_S(int idProduct)
        {
            if (_repository.DeleteReceiptInfoByIdProduct(idProduct))
                return true;
            return false;
        }

        public IEnumerable GetReceiptInfoByIdReceipt_S(int idReceipt)
        {
           return  _repository.GetReceiptInfoByIdReceipt(idReceipt);
        }
    }
}
