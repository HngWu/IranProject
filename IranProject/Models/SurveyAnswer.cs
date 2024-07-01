using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class SurveyAnswer
    {
        public int SurveyAnswerId { get; set; }
        public int SurveyId { get; set; }
        public int UserId { get; set; }
        public int SurveyOptionId { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual SurveyOption SurveyOption { get; set; }
        public virtual User User { get; set; }
    }
}
