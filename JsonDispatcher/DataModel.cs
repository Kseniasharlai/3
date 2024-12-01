namespace JsonDispatcher
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public Item(string name = "")
        {
            Name = name;
            Quantity = 0;
            Price = 0;
        }
    }

}