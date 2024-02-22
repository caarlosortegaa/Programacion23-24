
namespace TPVLib.Implementations
{
    public class RAMDatabase : IDatabase
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        private Dictionary<long, Ticket> _tickets = new Dictionary<long, Ticket>();
        private long _CurrentGeneratingId = 1;
        private long _CurrentTicketGeneratingId = 1;


        public void AddLineWithId(long id, TicketLine line)
        {

        }

        public long AddProduct(Product product)
        {
            var cloneProduct = product.Clone();
            cloneProduct.id = _CurrentGeneratingId++;
            _products.Add(product.id, cloneProduct);
            return cloneProduct.id;
        }

        public long AddTicket(TicketHeader header)
        {
            Ticket newTicket = new Ticket();
            var cloneTicket = header.Clone();
            cloneTicket.id = _CurrentTicketGeneratingId++;
            newTicket.header = cloneTicket;
            _tickets.Add(header.id, newTicket);
            return cloneTicket.id;
        }

        public Product? GetProductWithId(long id)
        {
            Product? product;
            if (_products.TryGetValue(id, out product))
            {
                return product.Clone();
            }
            return null;
        }

        public void RemoveProductWithID(long id)
        {
            if (_products.ContainsKey(id))
                _products.Remove(id);
        }

        public void UpdateProductWithId(long id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
