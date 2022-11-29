using System;

namespace DTO
{
    public class WarehouseIngredientDTO
    {
        public int _idFood;
        public string _status;
        public DateTime _warehouseDayAdd;
        public string _idRequireAdd;
        public string _idStaffAddtoWarehouse;
        public WarehouseIngredientDTO() { }
        public WarehouseIngredientDTO(int idFood, string status, DateTime warehouseDayAdd, string idRequireAdd, string idStaffAddtoWarehouse)
        {
            _idFood = idFood;
            _status = status;
            _warehouseDayAdd = warehouseDayAdd;
            _idRequireAdd = idRequireAdd;
            _idStaffAddtoWarehouse = idStaffAddtoWarehouse;
        }
        public int IdFood
        {
            get { return _idFood; }
            set { _idFood = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime WarehouseDayAdd
        {
            get { return _warehouseDayAdd; }
            set
            {
                _warehouseDayAdd = value;
            }
        }
        public string IdRequireAdd
        {
            get { return _idRequireAdd; }
            set
            {
                _idRequireAdd = value;
            }
        }
        public string IdStaffAddtoWarehouse
        {
            get { return _idStaffAddtoWarehouse; }
            set
            {
                _idStaffAddtoWarehouse = value;
            }
        }
    }
}
