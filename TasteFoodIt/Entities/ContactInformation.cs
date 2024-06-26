using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entities
{
    public class ContactInformation
    {
        public int ContactInformationId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
    }
}