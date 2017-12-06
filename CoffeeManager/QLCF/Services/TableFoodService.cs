using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;
using QLCF.Repository;

namespace QLCF.Services
{
    public class TableFoodService : ITableFoodService
    {
        ITableFoodRepository _repository;
        public TableFoodService(ITableFoodRepository repository)
        {
            this._repository = repository;
        }
        public IEnumerable<TableFood> GetAll()
        {
            return _repository.GetAll();
        }

        public void SwitchTable(int idP, int idC)
        {
            throw new NotImplementedException();
        }
    }
}
