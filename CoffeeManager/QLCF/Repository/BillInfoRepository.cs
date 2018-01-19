using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class BillInfoRepository : IBillInfoRepository<BillInfo>
    {
#region Singleton
        //private static BillInfoRepository instance;

        //public static BillInfoRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new BillInfoRepository();
        //        return instance;
        //    }
        //    private set => instance = value;
        //}
        #endregion
        private CFMEntities db = CFMEntities.Instance;
        public bool AddBillInfo(BillInfo billInfo)
        {
            try
            {
                db.BillInfoes.Add(billInfo);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// be used to delete food if food exist in billinfo
        /// </summary>
        /// <param name="idProduct"></param>
        /// <returns></returns>
        public bool DeleteBillInfoByIdProduct(int idProduct)
        {
            try
            {
                var billinfo = (from a in db.BillInfoes
                            where a.idProduct == idProduct
                            select a).ToList();
                foreach (var item in billinfo)
                {
                    db.BillInfoes.Remove(item);
                }
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable<BillInfo> GetListBillInfoByIdBill(int idBill)
        {
            return (from a in db.BillInfoes
                    where a.idBill == idBill
                    select a).ToList();
        }

        public bool UpdateBillInfo(BillInfo billInfo)
        {
            try
            {
                BillInfo originalBillInfo = db.BillInfoes.FirstOrDefault(q => q.id == billInfo.id);
                db.Entry(originalBillInfo).CurrentValues.SetValues(billInfo);
                db.SaveChanges();
            }catch
            {
                return false;
            }
            return true;
        }
    }
}
