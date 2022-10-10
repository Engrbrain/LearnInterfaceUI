// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using DemoLibrary;


Console.WriteLine("Hello, World!");
List<IProductModel> cart = AddSampleProduct(); 
CustomerModel customer = GetCustomer();

foreach (IProductModel product in cart) {
    product.ShipItem(customer);

    if (product is IDigitalProductModel digital)
    {
        Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
    }
}

static CustomerModel GetCustomer()
{
    return new CustomerModel
    {
        FirstName = "Harrison",
        LastName = "Uhunghama",
        City = "Benin City",
        EmailAddress = "Edo State",
        PhoneNumber = "+23498837223",
    };
}

static List<IProductModel> AddSampleProduct()
{
    List <IProductModel> newProducts = new List<IProductModel>();

    //Add Physical Products
    newProducts.Add(new PhysicalProductModel { Title = "Bic Pen Stylo" });
    newProducts.Add(new PhysicalProductModel { Title = "Harrison Tshirt" });
    newProducts.Add(new PhysicalProductModel { Title = "CK Belt" });

    //Add Digital Products
    newProducts.Add(new DigitalProductModel { Title = "Rich Dad Poor Dad" });

    // Add Course Products
    newProducts.Add(new CourseProductModel { Title = "Javascript Essentials Complete Course" });


    return newProducts;
}
