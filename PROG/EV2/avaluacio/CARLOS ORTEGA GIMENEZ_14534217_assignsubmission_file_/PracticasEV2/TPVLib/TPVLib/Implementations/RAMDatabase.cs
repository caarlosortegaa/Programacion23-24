
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
            // Javi: Sin implementar
            if (id < 0)
                throw new ArgumentException("el id no existe");
            
        }

        public long AddProduct(Product product)
        {
            var cloneProduct = product.Clone();
            cloneProduct.id = _CurrentGeneratingId++;
            // Javi: No, es el id del producto clonado
            _products.Add(product.id, cloneProduct);
            return cloneProduct.id;
        }
        public void UpdateProductWithId(long id, Product product)
        {
            if (_products.ContainsKey(id))
            {
                Product productExist = _products[id];
            }
            else
            {
                throw new Exception("No se encontró ningun producto con ese id");
            }
        }

        public long AddTicket(TicketHeader header)
        {
            // Javi: Esto está bien
            Ticket newTicket = new Ticket();
            var cloneTicket = header.Clone();
            cloneTicket.id = _CurrentTicketGeneratingId++;
            newTicket.header = cloneTicket;
            _tickets.Add(header.id, newTicket);
            return cloneTicket.id;
        }

        public long AddTicketHead(TicketHeader header)
        {
            throw new NotImplementedException();
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
            // Javi: No hace falta el contains
            if (_products.ContainsKey(id))
                _products.Remove(id);
        }

        public void RemoveTicketHead(TicketHeader header)
        {
            throw new NotImplementedException();
        }

        public void RemoveTicketLine(TicketLine ticketLine)
        {
            throw new NotImplementedException();
        }
    }
}
