namespace TPV
{
    public class RAMTPV : ITPV
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        public int ProductCount => _products.Count;
        private long _CurrentGeneratingId = 1;

        public long AddProduct(Product product)
        {
            var cloneProduct = product.Clone();
            cloneProduct.id = _CurrentGeneratingId++;
            _products.Add(product.id, cloneProduct);
            return cloneProduct.id;
            
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
