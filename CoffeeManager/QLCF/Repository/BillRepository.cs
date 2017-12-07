using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class BillRepository : IBillRepository<Bill>
    {
        #region Singleton
        //private static BillRepository instance;
        //public static BillRepository Instance
        //{
        //    get
        //    {
        //        if(instance == null)
        //            instance = new BillRepository();
        //            return instance;
        //    }
        //    private set
        //    {
        //        instance = value;
        //    }
        //}
        #endregion
        private Domain.CFMEntities db = CFMEntities.Instance;
        public bool AddBill(Bill bill)
        {
            try
            {
                db.Bills.Add(bill);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckOut(Bill bill)
        {
            Bill originalBill = GetBillById(bill.id);
            try
            {
                db.Entry(originalBill).CurrentValues.SetValues(bill);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Bill> GetAll()
        {
            return db.Bills.ToList();
        }

        public Bill GetBillById(int id)
        {
            return db.Bills.FirstOrDefault(c => c.id == id);
        }

        public int? GetMaxIdBill()
        {
            return db.Bills.Max(q => (int?)q.id);
        }

        /// <summary>
        /// Method to check bill was paid.
        /// Successful is return id of bill. If fail return -1
        /// </summary>
        /// <param name="idtable"></param>
        /// <returns></returns>
        public int GetUncheckBillByIdTable(int idtable)
        {
            var item = db.Bills.FirstOrDefault(c => c.idTable == idtable && c.status == 0);
            if (item != null)
                return item.id;
            return -1;
        }
        
    }
}
