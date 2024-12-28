using Example.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal SellPrice { get; set; }
    public decimal CostPrice { get; set; }
    public int Quantity { get; set; }
    public int Discount { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category{ get; set; } 
    public ICollection<ProductTag> Products { get; set; } 
}
