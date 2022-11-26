using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace FoodStoreManagement.DAL
{
    class FoodList_DAL
    {
        private static FoodList_DAL instance;
        public static FoodList_DAL Instance
        {
            get { if (instance == null) instance = new FoodList_DAL(); return FoodList_DAL.instance; }
            private set { FoodList_DAL.instance = value; }
        }
        private Ban_DAL() { }
    }
}
