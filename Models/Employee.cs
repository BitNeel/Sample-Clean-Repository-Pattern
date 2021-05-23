using System;
using System.Collections.Generic;

#nullable disable

namespace BlogPosts.Models
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumer { get; set; }
        public string CorrespondenceAddress { get; set; }
        public DateTime? CreatedDtm { get; set; }
        public string CreatedBy { get; set; }
    }
}
