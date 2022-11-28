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
        public bool insertData(WarehouseIngredientDTO dataDTO)
        {
            return dataDAL.insertData(dataDTO); 
        }
        public bool updateData(WarehouseIngredientDTO dataDTO)
        {
            return dataDAL.updateData(dataDTO);
        }
    }
}
