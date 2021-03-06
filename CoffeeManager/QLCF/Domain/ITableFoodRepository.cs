﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface ITableFoodRepository
    {
        IEnumerable<TableFood> GetAll();
        void SwitchTable(int idP, int idC);
        void UpdateStatus(TableFood tableFood);
    }
}
