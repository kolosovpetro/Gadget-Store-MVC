using System.Collections.Generic;
using AutoMapper;
using GadgetStoreMVC.Models.Models;
using GadgetStoreMVC.Models.ViewModel;
using GadgetStoreMVC.Repository.ConcreteRepositories;

namespace GadgetStoreMVC.Services.Services
{
    public class OrderServices
    {
        private readonly OrderRepository _orderRepository;

        public OrderServices(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrder(OrderModel order)
        {
            _orderRepository.Add(order);
            _orderRepository.Save();
        }

        // public Mapper MapperInit()
        // {
        //     var config = new MapperConfiguration(cfg => cfg
        //         .CreateMap<OrderModel, OrderViewModel>());
        //     var mapper = new Mapper(config);
        //     return mapper;
        // }

        public IEnumerable<OrderModel> GetUserOrders(string userId)
        {
            var orders = _orderRepository
                .GetMany(x => x.UserId == userId);
            return orders;
        }

        public OrderModel GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void Save()
        {
            _orderRepository.Save();
        }

        public void Update(OrderModel order)
        {
            _orderRepository.Update(order);
        }

        public void Delete(OrderModel order)
        {
            _orderRepository.Delete(order);
        }
    }
}
