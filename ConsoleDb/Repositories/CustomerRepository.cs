using ConsoleDb.Context;
using ConsoleDb.Entity;

namespace ConsoleDb.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }

}
