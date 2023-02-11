public class ProductController
{
    private Database Db;
    public ProductController(Database db)
    {
        this.Db = db;
    }
    public Product? GetProduct(Guid id)
    {
        var result = Db.ProductDb.FirstOrDefault(item => item.ProductId == id);
        if (result is null)
        {
            Console.WriteLine($"Product with id {id} not found");
            return null;
        }
        else
        {
            return result;
        }
    }
}