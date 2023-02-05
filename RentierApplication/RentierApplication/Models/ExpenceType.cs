using System;
using System.Collections.Generic;

namespace RentierApplication.Models;

public partial class ExpenceType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<RealEstateExpence> RealEstateExpences { get; } = new List<RealEstateExpence>();
}
