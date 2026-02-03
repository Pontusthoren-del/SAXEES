using System;
using System.Collections.Generic;

namespace SAXEES.Models;

public partial class Booking
{
    public int Id { get; set; }

    public DateTime Time { get; set; }

    public int? StaffId { get; set; }

    public int? TreatmentsId { get; set; }

    public int? CustomersId { get; set; }

    public virtual Customer? Customers { get; set; }

    public virtual Staff? Staff { get; set; }

    public virtual Treatment? Treatments { get; set; }
}
