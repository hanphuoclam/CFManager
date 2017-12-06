using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class ReceiptInfoRepository : IReceiptInfoRepository<ReceiptInfo>
    {
        #region Singleton
        //private static ReceiptInfoRepository instance;

        //public static ReceiptInfoRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new ReceiptInfoRepository();
        //        return instance;
        //    }
        //    private set => instance = value;
        //}
        #endregion
        private Domain.CFMEntities db = CFMEntities.Instance;
        public bool AddReceiptInfo(ReceiptInfo receiptInfo)
        {
            try
            {
                db.ReceiptInfoes.Add(receiptInfo);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteReceiptInfoByIdProduct(int idProduct)
        {
            try
            {
                var receipt = (from c in db.ReceiptInfoes
                               where c.idProduct == idProduct
                               select c).ToList();
                foreach (var item in receipt)
                    db.ReceiptInfoes.Remove(item);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        
        IEnumerable<ReceiptInfo> IReceiptInfoRepository<ReceiptInfo>.GetReceiptInfoByIdReceipt(int idReceipt)
        {
            return (from c in db.ReceiptInfoes
                    where c.idReceipt == idReceipt
                    select c).ToList();
        }
    }
}
