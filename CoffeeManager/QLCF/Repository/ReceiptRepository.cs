using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class ReceiptRepository : IReceiptRepository<Receipt>
    {
        #region Singleton
        //private static ReceiptRepository instance;

        //public static ReceiptRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new ReceiptRepository();
        //        return instance;
        //    }
        //    private set => instance = value;
        //}
        #endregion
        private CFMEntities db = CFMEntities.Instance;
        public bool AddReceipt(Receipt receipt)
        {
            try
            {
                db.Receipts.Add(receipt);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public int? GetMaxIdReceipt()
        {
            return db.Receipts.Max(q => (int?)q.id);
        }

        public void Pay(Receipt receipt)
        {
            try
            {
                Receipt originalRe = db.Receipts.FirstOrDefault(c => c.id == receipt.id);
                db.Entry(originalRe).CurrentValues.SetValues(receipt);
                db.SaveChanges();
            }
            catch
            {
            }
        }
    }
}
