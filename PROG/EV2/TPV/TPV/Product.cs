namespace TPV
{
    public class Product
    {
        public long id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public bool Available { get; set; }

        public Product Clone()
        {
            var cloneProduct = new Product();
            cloneProduct.id = id;
            cloneProduct.Name = Name;
            cloneProduct.Description = Description;
            cloneProduct.Price = Price;
            cloneProduct.Stock = Stock;
            cloneProduct.Available = Available;
            return cloneProduct;
        }
    }
}
