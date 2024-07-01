using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class User
    {
        public User()
        {
            SurveyAnswer = new HashSet<SurveyAnswer>();
            WorkshopRequest = new HashSet<WorkshopRequest>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int? Tel { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswer { get; set; }
        public virtual ICollection<WorkshopRequest> WorkshopRequest { get; set; }
    }
}
