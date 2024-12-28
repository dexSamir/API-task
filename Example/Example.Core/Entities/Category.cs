using Example.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Entities; 

public class Category : BaseEntity 
{
    public string Name { get; set; } 
    public string Icon { get; set; } 
    public ICollection<Product> Products { get; set; } 
}
