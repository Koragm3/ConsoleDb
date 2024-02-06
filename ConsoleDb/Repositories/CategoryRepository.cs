using ConsoleDb.Context;
using ConsoleDb.Entity;

namespace ConsoleDb.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }

}
