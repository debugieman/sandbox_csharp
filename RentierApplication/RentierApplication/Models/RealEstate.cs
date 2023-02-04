using System;
using System.Collections.Generic;

namespace RentierApplication.Models;

public partial class RealEstate
{
    public int Id { get; set; }

    public string Street { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<RealEstateExpence> RealEstateExpences { get; } = new List<RealEstateExpence>();
}
