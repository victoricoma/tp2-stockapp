using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
