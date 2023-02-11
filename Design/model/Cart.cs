public class Cart
{
    public Guid UserId { get; set; }
    public List<CartItem> CartItems { get; set; }

    public Cart(Guid userId)
    {
        UserId = userId;
        CartItems = new List<CartItem>();
    }
}