using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institution.Domain.Models.IdentityModel
{
    public class User:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime BirthDate { get; set; }
        public short GradeCode { get; set; }
        public string Address { get; set; }

        // Location

        // Navigations

    }
}
