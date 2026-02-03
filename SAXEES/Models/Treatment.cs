using System;
using System.Collections.Generic;

namespace SAXEES.Models;

public partial class Treatment
{
    public int Id { get; set; }

    public decimal Price { get; set; }

    public int Duration { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
