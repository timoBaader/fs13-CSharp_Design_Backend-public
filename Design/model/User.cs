public class User
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }

    public User(string userName, string userEmail, Database db)
    {
        UserId = Guid.NewGuid();
        UserName = userName;
        UserEmail = userEmail;

        // Create a Cart for the user
        db.UserCartDb.Add(new Cart(UserId));
    }
}