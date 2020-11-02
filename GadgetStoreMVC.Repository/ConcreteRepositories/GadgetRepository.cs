using GadgetStoreMVC.Data.Context;
using GadgetStoreMVC.Models.Models;
using GadgetStoreMVC.Repository.BaseRepository;

namespace GadgetStoreMVC.Repository.ConcreteRepositories
{
    public class GadgetRepository : RepositoryBase<GadgetModel>
    {
        public GadgetRepository(PostgresContext storeContext) : base(storeContext)
        {
        }
    }
}