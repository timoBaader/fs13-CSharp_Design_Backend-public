public class Category
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    public Category(string name, string image)
    {
        CategoryId = Guid.NewGuid();
        Name = name;
        Image = image;
    }
}
