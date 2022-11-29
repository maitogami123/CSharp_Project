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
        //public bool _updateData(WarehouseIngredientDTO dataDTO)
        //{
        //    return dataDAL.updateData(dataDTO);
        //}
        public DataTable updateData(WarehouseIngredientDTO dataDTO)
        {
            return dataDAL.updateData(dataDTO);
        }
    }
}
