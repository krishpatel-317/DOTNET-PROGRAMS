using System.Runtime.Intrinsics.Arm;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int price { get; set; }
    public int discount { get; set; }

    public static double discountAmount(Product p)
    {
        return (p.discount * p.price)/100.0;
    }
    public static double finalPrice(Product p)
    {
        double discAmt = discountAmount(p);
        return p.price - discAmt;
    }
    public static void Display(Product p)
    {
        Console.WriteLine($"Id: {p.Id}");
        Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine($"Category: {p.Category}");
        Console.WriteLine($"Price: {p.price}");
        Console.WriteLine($"Discount: {p.discount}%");
        Console.WriteLine($"Discount Amount: {discountAmount(p)}");
        Console.WriteLine($"Final Price: {finalPrice(p)}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1,Name="Washing Machine",Category="Electronics",price=20300,discount=5 }, // 5% discount
            new Product { Id = 2,Name="AC",Category="Home Applience",price=45500,discount=10 },
            new Product { Id = 3,Name="Laptop",Category="Electronics",price=65000,discount=15 },
            new Product { Id = 4,Name="Mobile",Category="Electronics",price=20000,discount=3 },
            new Product { Id = 5,Name="Fan",Category="Home Applience",price=2000,discount=2 },
        };
        Func<Product, double> da = Product.discountAmount;
        Func<Product, double> fp = Product.finalPrice;
        Action<Product> ac = Product.Display;
        foreach(var i in products)
        {
            ac(i);
            Console.Write("Discount price and final prices are: ");
            Console.WriteLine($"{da(i)} and {fp(i)}");
            Console.WriteLine();
        }
    }
}