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
        private string query;
        public WarehouseIngredientDAL() { }
        public DataTable getData()
        {
            query = string.Format("select idFood as [Mã thức ăn], Status as [Tình trạng], WarehouseDayAdd as [Ngày Nhập], idRequireAdd as [Số Lượng], idStaffAddtoWarehouse as [Mã nhân viên] from WarehouseIngredient");
            return funcDAL.getData(query);
        }

        public bool insertData(WarehouseIngredientDTO dataDTO)
        {
            query = string.Format("insert into WarehouseIngredient values({0},'{1}','{2}','{3}','{4}')",dataDTO.IdFood,dataDTO.Status, dataDTO.WarehouseDayAdd,dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            return funcDAL.func(query, dataDTO);
        }

        public bool updateData(WarehouseIngredientDTO dataDTO)
        {
            query = string.Format("update WarehouseIngredient set idFood = {0}, Status = '{1}', WarehouseDayAdd = '{2}', idRequireAdd = '{3}', idStaffAddtoWarehouse = '{4}'", 
                dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            return funcDAL.func(query, dataDTO);
        }
        public bool delData(WarehouseIngredientDAL dataDTO)
        {
            return false;
        }
    }
}
