using model;

public class ProductController
{
    private Db db;
    public ProductController(Db db)
    {
        this.db = db;
    }
    public Product? GetProduct(Guid id)
    {
        var result = db.productDb.FirstOrDefault(item => item.ProductId == id);
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