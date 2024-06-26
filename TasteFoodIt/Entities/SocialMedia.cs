using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string PlatformName { get; set; }
        public string RedirectUrl { get; set; }
        public string IcanUrl { get; set; }
        public bool Status { get; set; }
    }
}