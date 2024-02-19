namespace TPVLib
{
    public class RAMTPV : ITPV
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        public int ProductCount => _products.Count;
        private long _CurrentGeneratingId = 1;
        IDatabase _database;

        public long AddProduct(Product product)
        {
            var cloneProduct = product.Clone();
            cloneProduct.id = _CurrentGeneratingId++;
            _products.Add(product.id, cloneProduct);
            return cloneProduct.id;
            
        }

        public Product? GetProductWithId(long id)
        {
            Product? product;
            if(_products.TryGetValue(id, out product))
            {
                return product.Clone();
            }
            return null;
        }

        public void RemoveProductWithID(long id)
        {
            if(_products.ContainsKey(id))
            _products.Remove(id);
        }

        public void UpdateProductWithId(long id, Product updateProduct)
        {       
        }

        public long AddTicket(Ticket ticket)
        {
            return ticket.header.id;
        }
    }
}
