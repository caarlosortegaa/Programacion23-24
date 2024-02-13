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
            _products.TryGetValue(id, out var product);
            return product;
        }

        public void RemoveProductWithID(long id)
        {
            _products.Remove(id);
        }

        public void UpdateProductWithId(long id, Product updateProduct)
        {
            if(_products.ContainsKey(id))
            {
                var cloneProduct = updateProduct.Clone();
                _products[id] = cloneProduct;
            }
            else
            {
                throw new Exception("$\"Producto con id no encontrado\"");
            }
        }
        public bool ContainsWithId(long id) =>  _products.ContainsKey(id);
        
        public bool ContainsWithProduct(Product product) => _products.ContainsValue(product);
    }
}
