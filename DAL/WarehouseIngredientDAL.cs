using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseIngredientDAL
    {
        private FunctionsDAL funcDAL = new FunctionsDAL();
        private string quety;
        public DataTable getData()
        {
            quety = string.Format("select * from WarehouseIngredient");
            return funcDAL.getData(quety);
        }

        public bool insertData(WarehouseIngredientDTO dataDTO)
        {
            quety = string.Format("insert into WarehouseIngredient(idFood, Status, WarehouseDayAdd, idRequireAdd, idStafftoAddWarehouse) values('{0}','{1}','{2}','{3}','{4}')",
                dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            return funcDAL.func(quety, dataDTO);
        }

        public bool updateData(WarehouseIngredientDTO dataDTO)
        {
            quety = string.Format("update WarehouseIngredient set idFood = {0}, Status = '{1}', WarehouseDayAdd = '{2}', idRequireAdd = '{3}', idStafftoAddWarehouse = '{4}'", 
                dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            return funcDAL.func(quety, dataDTO);
        }
    }
}
