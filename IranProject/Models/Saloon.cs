using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class Saloon
    {
        public Saloon()
        {
            WorkshopRequest = new HashSet<WorkshopRequest>();
        }

        public int SaloonId { get; set; }
        public string SaloonName { get; set; }

        public virtual ICollection<WorkshopRequest> WorkshopRequest { get; set; }
    }
}
