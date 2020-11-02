using GadgetStoreMVC.Models.Models;

namespace GadgetStoreMVC.Models.ViewModel
{
    public class OrderViewModel : OrderModel
    {
        public string GadgetName { get; set; }
        public float GadgetPrice { get; set; }
    }
}
