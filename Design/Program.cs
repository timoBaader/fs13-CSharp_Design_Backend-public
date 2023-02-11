
using model;

Db db = new Db();
ProductController productController = new ProductController(db);

Category horror = new Category("horror", "/location/horror.png");

Product product1 = new Product("hello", "super nice", horror.CategoryId, "location/image.jpg");

db.productDb.Add(product1);

var result = productController.GetProduct(product1.ProductId);

Console.WriteLine(result.Title);

