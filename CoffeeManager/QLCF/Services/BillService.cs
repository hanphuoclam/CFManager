using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class BillService : IBillService<Bill>
    {
        private IBillRepository<Bill> _repository;

        public BillService(IBillRepository<Bill> repository)
        {
            this._repository = repository;
        }
        public bool AddBill_S(Bill bill)
        {
            if (_repository.AddBill(bill))
                return true;
            return false;
        }

        public bool CheckOut_S(Bill bill)
        {
            if (_repository.CheckOut(bill))
                return true;
            return false;
        }

        public IEnumerable GetAll_S()
        {
            return _repository.GetAll();
        }

        public Bill GetBillById_S(int id)
        {
            return _repository.GetBillById(id);
        }

        public int GetUncheckBillByIdTable_S(int idtable)
        {
            return _repository.GetUncheckBillByIdTable(idtable);
        }
    }
}
