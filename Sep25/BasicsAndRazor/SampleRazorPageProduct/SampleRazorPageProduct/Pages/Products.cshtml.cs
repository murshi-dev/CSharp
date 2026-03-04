using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleRazorPageProduct.Models;

namespace SampleRazorPageProduct.Pages
{
    public class ProductsModel : PageModel
    {
        //create object for Product class
        [BindProperty]
        public Product ProductData { get; set; } = new Product();

        //to store total after calculation
        public double Total {  get; set; }
        //call the OnPost when calculate is clicked
        public void OnPost()
        {
            Total = ProductData.calTotal();
        }
    }
}
