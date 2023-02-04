using System;
using System.Collections.Generic;

namespace RentierApplication.Models;

public partial class RealEstateExpence
{
    public int Id { get; set; }

    public int RealEstateId { get; set; }

    public int ExpenceTypeId { get; set; }

    public decimal Value { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public virtual RealEstate RealEstate { get; set; } = null!;
}
