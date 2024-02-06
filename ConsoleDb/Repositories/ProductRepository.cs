using ConsoleDb.Context;
using ConsoleDb.Entity;

namespace ConsoleDb.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }

}
