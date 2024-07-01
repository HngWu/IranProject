using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class WorkshopRequest
    {
        public int WorkshopRequestId { get; set; }
        public int UserId { get; set; }
        public int SaloonId { get; set; }
        public int CategoryId { get; set; }
        public int WorkshopTimeId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual User User { get; set; }
        public virtual WorkshopTime WorkshopTime { get; set; }
    }
}
