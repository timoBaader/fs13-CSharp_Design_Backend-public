namespace model
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public string Images { get; set; } = string.Empty;

        public Product(string title, string description, Guid categoryId, string images)
        {
            ProductId = Guid.NewGuid();
            Title = title;
            Description = description;
            CategoryId = categoryId;
            Images = images;
        }
    }
}
