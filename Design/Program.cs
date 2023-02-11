Database Db = new Database();
ProductController productController = new ProductController(Db);
UserController userController = new UserController(Db);

Category horror = new Category("horror", "/location/horror.png");

Product product1 = new Product("hello", "super nice", horror.CategoryId, "location/image.jpg");

Db.ProductDb.Add(product1);

var result = productController.GetProduct(product1.ProductId);

Console.WriteLine(result?.Title);

User Timo = new User("timo", "timo@mail.com", Db);

userController.AddProductToCart(Timo.UserId, product1.ProductId, 2);

var TimosCartItems = userController.GetUserCart(Timo.UserId)?.CartItems;

TimosCartItems?.ForEach(x => Console.WriteLine($"Product id: {x.ProductId}, product quantity: {x.Quantity}"));