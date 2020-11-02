namespace GadgetStoreMVC.Models.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int GadgetId { get; set; }
        public string UserId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
