namespace TPVLib
{
    public interface IDatabase
    {
        long AddProduct(Product product);
        void RemoveProductWithID(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id, Product product);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithID(product.id);
        }
        long AddTicket(TicketHeader ticket);
        void AddLineWithId(long id, TicketLine line);
        void RemoveTicketLine(TicketLine ticketLine);
        long AddTicketHead(TicketHeader header);
        void RemoveTicketHead(TicketHeader header);


    }
}
