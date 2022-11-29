using DTO;
using System.Data;

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

        public DataTable insertData(WarehouseIngredientDTO dataDTO)
        {
            query = string.Format("insert into WarehouseIngredient values({0},'{1}','{2}','{3}','{4}')", dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            return funcDAL.func(query, dataDTO);
        }

        public DataTable updateData(WarehouseIngredientDTO dataDTO)
        {
            //query = string.Format("update WarehouseIngredient set Status = '{0}', WarehouseDayAdd = '{1}', idRequireAdd = '{2}', idStaffAddtoWarehouse = '{3}' where idFood = {4}"
            //    ,dataDTO.Status, dataDTO.WarehouseDayAdd,dataDTO.IdStaffAddtoWarehouse,dataDTO.IdStaffAddtoWarehouse,dataDTO.IdFood);

            //query = string.Format("update WarehouseIngredient set idFood = {0}, Status = '{1}', WarehouseDayAdd = '{2}', idRequireAdd = '{3}', idStaffAddtoWarehouse = '{4}'"
            //    , dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdRequireAdd, dataDTO.IdStaffAddtoWarehouse);
            query = string.Format("update WarehouseIngredient set idFood = {0}, Status = '{1}', WarehouseDayAdd = '{2}', idRequireAdd = '{3}', idStaffAddtoWarehouse = '{4}' where idFood = {5}",
               dataDTO.IdFood, dataDTO.Status, dataDTO.WarehouseDayAdd, dataDTO.IdStaffAddtoWarehouse, dataDTO.IdStaffAddtoWarehouse, dataDTO.IdFood);
            return funcDAL.func(query, dataDTO);
        }
        public bool delData(WarehouseIngredientDAL dataDTO)
        {
            return false;
        }
    }
}
