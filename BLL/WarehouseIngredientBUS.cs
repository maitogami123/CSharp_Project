using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WarehouseIngredientBUS
    {
        WarehouseIngredientDAL dataDAL = new WarehouseIngredientDAL();
        public DataTable getData()
        {
            return dataDAL.getData();
        }
        public DataTable insertData(WarehouseIngredientDTO dataDTO)
        {
            return dataDAL.insertData(dataDTO); 
        }
        public DataTable updateData(WarehouseIngredientDTO dataDTO)
        {
            DataTable data = new DataTable();
            data = dataDAL.delData(dataDTO.IdFood);
            data = dataDAL.insertData(dataDTO);
            return data;
        }
        public DataTable delData(int idFood)
        {
            return dataDAL.delData(idFood);
        }
    }
}
