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
            var billexist = GetListBillInfoByIdBill(billInfo.idBill);
            foreach(BillInfo item in billexist)
            {
                if(item.idProduct == billInfo.idProduct)
                {
                    try
                    {
                        if (billInfo.count + item.count >= 0)
                            item.count += billInfo.count;
                        else
                            return false;
                        UpdateBillInfo(item);
                        db.SaveChanges();
                        return true;
                    }catch
                    {

                    }
                }
            }
            if (billInfo.count <= 0)
                return false;
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

        public BillInfo GetBillInfoById(int id)
        {
            return db.BillInfoes.Where(c => c.id == id).FirstOrDefault();
        }

        public IEnumerable<BillInfo> GetListBillInfoByIdBill(int idBill)
        {
            var listBillInfo = (from a in db.BillInfoes
                    where a.idBill == idBill
                    select a).ToList();
            foreach(BillInfo item in listBillInfo)
            {
                if (item.count == 0)
                    DeleteBillInfoByIdProduct(item.idProduct);
            }
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
