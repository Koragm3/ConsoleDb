using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb.Entity
{
    internal class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;

    }
}
