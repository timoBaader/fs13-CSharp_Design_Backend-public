public class UserController
{
    private Database Db;
    public UserController(Database db)
    {
        this.Db = db;
    }
    public CartItem? AddProductToCart(Guid userId, Guid productId, int quantity)
    {
        var UserCart = GetUserCart(userId);
        if (UserCart is null) return null;
        var Data = new CartItem(productId, quantity);
        UserCart.CartItems.Add(Data);
        return Data;
    }

    public Cart? GetUserCart(Guid userId)
    {
        var UserCart = Db.UserCartDb.FirstOrDefault(item => item.UserId == userId);
        if (UserCart is null)
        {
            Console.WriteLine("Cart could not be found");
            return null;
        }
        else
        {
            return UserCart;
        }
    }

}