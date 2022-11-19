namespace DTO
{
    public class DTO_Supplier 
    {
        int _idSupplier;
        string _supplierName, _address, _mail, _phone;
        public DTO_Supplier()
        {
            _idSupplier = 0;
            _supplierName = "";
            _address = "";
            _mail = "";
            _phone = "";
        }
        public DTO_Supplier(int idSupplier, string supplierName, string address, string mail, string phone)
        {
            _idSupplier = idSupplier;
            _supplierName = supplierName;
            _address = address;
            _mail = mail;
            _phone = phone;
        }
        public int IdSupplier
        {
            get { return _idSupplier; }
            set { _idSupplier = value; }
        }
        public string SupplierName
        {
            get { return _supplierName; }
            set { _supplierName = value; }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        public string Mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
            }
        }
        //public override string[] toArrayString()
        //{
        //    return new string[] { _idSupplier, _supplierName, _address, _mail, _phone };
        //}
    }
}
