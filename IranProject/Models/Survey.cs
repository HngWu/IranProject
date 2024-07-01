using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyAnswer = new HashSet<SurveyAnswer>();
            SurveyOption = new HashSet<SurveyOption>();
        }

        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<SurveyAnswer> SurveyAnswer { get; set; }
        public virtual ICollection<SurveyOption> SurveyOption { get; set; }
    }
}
