using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiscountDetailBUS
    {
        public DiscountDetailBUS() { }
        public DiscountDetailDAL dataDAL = new DiscountDetailDAL();
        public DataTable getData()
        {
            return dataDAL.getData();
        }
    }
}
