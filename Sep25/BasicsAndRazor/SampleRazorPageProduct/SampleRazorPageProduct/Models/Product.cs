namespace SampleRazorPageProduct.Models
{
    public class Product
    {
        public string PName {  get; set; }
        public double PPrice {  get; set; }
        public int PQuantity {  get; set; }
        public double calTotal()
        {
            return (PPrice * PQuantity);
        }
    }
}
