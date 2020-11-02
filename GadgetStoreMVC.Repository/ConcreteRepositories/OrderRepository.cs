using GadgetStoreMVC.Data.Context;
using GadgetStoreMVC.Models.Models;
using GadgetStoreMVC.Repository.BaseRepository;

namespace GadgetStoreMVC.Repository.ConcreteRepositories
{
    public class OrderRepository : RepositoryBase<OrderModel>
    {
        public OrderRepository(PostgresContext storeContext) : base(storeContext)
        {
        }
    }
}
