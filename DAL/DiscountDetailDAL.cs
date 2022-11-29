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
            query = string.Format("select * from DiscountDetail");
            return dataDAL.getData(query);
        }
    }
}
