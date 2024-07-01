using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class SurveyOption
    {
        public SurveyOption()
        {
            SurveyAnswer = new HashSet<SurveyAnswer>();
        }

        public int SurveyOptionId { get; set; }
        public string SurveyOptionName { get; set; }
        public int SurveyId { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswer { get; set; }
    }
}
