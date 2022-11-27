using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class FoodList
    {
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
        private int idCategoryFood;
        public int IDCategoryFood
        {
            get { return idCategoryFood; }
            set { idCategoryFood = value; }
        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public FoodList(int id, string foodName, int idCategoryFood, float price)
        {
            this.ID = id;
            this.FoodName = foodName;
            this.IDCategoryFood = idCategoryFood;
            this.Price = price;
        }
        public FoodList(DataRow row)
        {
            this.ID = (int)row["id"];
            this.FoodName = row["FoodName"].ToString();
            this.IDCategoryFood = (int)row["idCategoryFood"];
            this.Price = (float)row["price"];
        }
    }
}
