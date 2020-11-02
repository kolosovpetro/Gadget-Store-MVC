using AutoMapper;
using GadgetStoreMVC.Models.Models;
using GadgetStoreMVC.Models.ViewModel;

namespace GadgetStoreMVC.Profiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<GadgetModel, GadgetViewModel>();
            CreateMap<OrderModel, OrderViewModel>();
        }
    }
}