using Example.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Entities;

public class Tag : BaseEntity 
{
    public string Name{ get; set; } 
    public ICollection<ProductTag> Tags { get; set; }   
}
