using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class BillInfoService : IBillInfoService<BillInfo>
    {
        private IBillInfoRepository<BillInfo> _repository;

        public BillInfoService(IBillInfoRepository<BillInfo> repository)
        {
            this._repository = repository;
        }
        public bool AddBillInfo_S(BillInfo billInfo)
        {
            if (_repository.AddBillInfo(billInfo))
                return true;
            return false;
        }

        public bool DeleteBillInfoByIdProduct_S(int idProduct)
        {
            if (_repository.DeleteBillInfoByIdProduct(idProduct))
                return true;
            return false;
        }

        public BillInfo GetBillInfoById_S(int id)
        {
            return _repository.GetBillInfoById(id);
        }

        public IEnumerable GetListBillInfoByIdBill_S(int idBill)
        {
            return _repository.GetListBillInfoByIdBill(idBill);
        }

        public bool UpdateBillInfo_S(BillInfo billInfo)
        {
            return _repository.UpdateBillInfo(billInfo);
        }
    }
}
