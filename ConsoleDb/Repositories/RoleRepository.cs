using ConsoleDb.Context;
using ConsoleDb.Entity;

namespace ConsoleDb.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }

}
