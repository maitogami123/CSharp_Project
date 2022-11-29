using System.Data;

namespace FoodStoreManagement.DAL
{
    public class FoodList_DAL
    {
        public static FoodList_DAL instance;
        public static FoodList_DAL Instance
        {
            get { if (instance == null) instance = new FoodList_DAL(); return FoodList_DAL.instance; }
            private set { FoodList_DAL.instance = value; }
        }
        public DataTable DeleteRow(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("DELETE FROM Food WHERE id = " + id);
            return data;
        }
        public DataTable AddRow(string foodName, int idCategory, float price)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT INTO Food (FoodName, idCategoryFood,Price) VALUES(N'"+foodName+"', "+idCategory+", "+price+")");
            return data;
        }
        public DataTable UpdateRow(int id, string foodName, int idCategory, float price)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("UPDATE Food SET FoodName= N'" + foodName + "', Price =" + price + " WHERE id =" + id);
            return data;
        }
        public DataTable LoadTableList()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food");
            return data;
        }
         
        public DataTable SearchType(string category)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.Food.id, FoodName,idCategoryFood,Price FROM dbo.Food ,dbo.CategoryFood WHERE dbo.Food.idCategoryFood = dbo.CategoryFood.id AND category=N'" + category + "' ");
            return data;
        }

        // Filter 
        public DataTable FilterPriceASC()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food ORDER BY Price ");
            return data;
        }
        public DataTable FilterPriceDESC()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food ORDER BY Price DESC ");
            return data;
        }
        public DataTable FilterFoodNameASC()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food ORDER BY FoodName ");
            return data;
        }
        public DataTable FilterFoodNameDESC()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food ORDER BY FoodName DESC ");
            return data;
        }

        //Search Name Food
        public DataTable SearchFoodName(string input)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Food WHERE FoodName LIKE N'%"+input+"%'");
            return data;
        }


        //Validate
        public DataTable ValidateAddForm__idCategory()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select id from CategoryFood ");
            return data;
        }


    }
}
