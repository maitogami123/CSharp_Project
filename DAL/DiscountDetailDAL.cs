using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiscountDetailDAL
    {
        public DiscountDetailDAL() { }
        public FunctionsDAL dataDAL = new FunctionsDAL();
        public string query;
        public DataTable getData()
        {
            query = "select idDiscount as [Mã số], DiscountPercent as [Phần trăm được giảm], DateTimeDiscount as [Hạn sử dụng], idFoodUsingDiscount as [Mã thức ăn] from DiscountDetail";
            return dataDAL.getData(query);
        }
    }
}
