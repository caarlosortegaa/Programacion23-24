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
            throw new NotImplementedException();
        }

        public long AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public long AddTicket(TicketHeader ticket)
        {
            throw new NotImplementedException();
        }

        public Product? GetProductWithId(long id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductWithID(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductWithId(long id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
