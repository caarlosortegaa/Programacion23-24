namespace TPVLib
{
    public interface ITPV
    {
        public RAMTPV CreateNewTPV()
        {
            return new RAMTPV();
        }
        int ProductCount{  get; }
        long AddProduct(Product product);
        void RemoveProductWithID(long id);
        Product? GetProductWithId(long id);
        void UpdateProductWithId(long id,  Product product);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithID(product.id);
        }
        long AddTicket(Ticket ticket);
        // Javi: Falta todo lo de los tickets
    }
}
