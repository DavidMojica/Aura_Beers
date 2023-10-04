using System;
using System.Collections.Generic;

namespace AuraSP.Models;

public partial class Brand
{
    public Brand()
    {
        Beers = new HashSet<Beer>();
    }
    public int BrandId { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
