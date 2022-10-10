using System;
namespace DemoLibrary
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; } = default!;

        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Added the {Title} course to {customer.FirstName}'s account");
                HasOrderBeenCompleted = true;
            }
        }
    }
}

