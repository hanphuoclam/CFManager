using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class TableFoodRepository : ITableFoodRepository
    {
        CFMEntities db = CFMEntities.Instance;
        public IEnumerable<TableFood> GetAll()
        {
            return db.TableFoods.ToList();
        }

        public void SwitchTable(int idP, int idC)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(TableFood tableFood)
        {
            TableFood table = db.TableFoods.FirstOrDefault(q => q.id == tableFood.id);
            tableFood.name = table.name;
            db.Entry(table).CurrentValues.SetValues(tableFood);
            db.SaveChanges();
        }
    }
}
