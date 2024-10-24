using Cw8.Entities;
using Cw8.InitialData;
using Cw8.Service;
SeedData.SeedDataa();
ProductService productService = new ProductService();
var option = 0;
do
{
    Console.Clear();
    Console.WriteLine("1.Add Product");
    Console.WriteLine("2.List of Products");
    Console.WriteLine("3.Remove Product");
    Console.WriteLine("4.Products Details");
    Console.WriteLine("5.Update Product");
    Console.WriteLine("6.Log out");
    option = Int32.Parse(Console.ReadLine()!);
    switch(option)
    {
        case 1:
            Console.Write("Enter Name of Product: ");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter Id of Product: ");
            var id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter category of Products: ");
            var Cat = Console.ReadLine();
            Console.WriteLine("Enter the price of product:  ");
            var price = Int32.Parse(Console.ReadLine());
            Product product = new(id,Name,Cat,price);
            var res = productService.AddProduct(product);
            Console.WriteLine(res.Message);
            Console.WriteLine("Pressany key...");
            Console.ReadKey();  
            break;
        case 2:
            Console.WriteLine("==========Products===========");
            productService.ListOfProducts();
            Console.WriteLine("=============================");
            Console.WriteLine("Pressany key...");
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("==========Remove Products=======");
            break;
        case 4:
            break;
        case 5:
            break;
    }
}
while(option<6);