namespace TPVLib
{
    public class RAMTPV : ITPV
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        public int ProductCount => _products.Count;
        IDatabase _database;
        public RAMTPV(IDatabase database)
        {
            _database = database;
        }

        public RAMTPV()
        {

        }

        public long AddProduct(Product product)
        {
            return _database.AddProduct(product);
            
        }

        public Product? GetProductWithId(long id)
        {
            return _database.GetProductWithId(id);
        }

        public void RemoveProductWithID(long id)
        {
            _database.RemoveProductWithID(id);
        }

        public void UpdateProductWithId(long id, Product updateProduct)
        {       
            _database.UpdateProductWithId(id, updateProduct);
        }

        public long AddTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
