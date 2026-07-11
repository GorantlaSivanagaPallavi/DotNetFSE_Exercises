using Exercise_01_RetailInventorySystem;
using Exercise_01_RetailInventorySystem.Models;

AppDbContext db = new AppDbContext();

// Create Category
Category category = new Category
{
    CategoryName = "Electronics"
};

db.Categories.Add(category);
db.SaveChanges();

// Create Product
Product product = new Product
{
    ProductName = "Laptop",
    Price = 55000,
    Stock = 20,
    CategoryId = category.CategoryId
};

db.Products.Add(product);
db.SaveChanges();

Console.WriteLine("Product Added Successfully!");

Console.WriteLine("\nProduct List");

foreach (var item in db.Products)
{
    Console.WriteLine($"{item.ProductId} - {item.ProductName} - ₹{item.Price}");
}
