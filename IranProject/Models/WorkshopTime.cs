using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class WorkshopTime
    {
        public WorkshopTime()
        {
            WorkshopRequest = new HashSet<WorkshopRequest>();
        }

        public int WorkshopTimeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<WorkshopRequest> WorkshopRequest { get; set; }
    }
}
