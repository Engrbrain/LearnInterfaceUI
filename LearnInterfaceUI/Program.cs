// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using DemoLibrary;

Console.WriteLine("Hello, World!");
List<PhysicalProductModel> cart = AddSampleProduct();
CustomerModel customer = GetCustomer();

foreach (PhysicalProductModel product in cart) {
    product.ShipItem(customer);
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

static List<PhysicalProductModel> AddSampleProduct()
{
    List <PhysicalProductModel> newProducts = new List<PhysicalProductModel>();
    newProducts.Add(new PhysicalProductModel { Title = "Bic Pen Stylo" });
    newProducts.Add(new PhysicalProductModel { Title = "Harrison Tshirt" });
    newProducts.Add(new PhysicalProductModel { Title = "CK Belt" });

    return newProducts;
}
