using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCSWinRemaxApp.Models;

namespace prjCSWinRemaxApp.Models
{
    public class PropertyListing
    {
        public int PropertyListingId { get; set; }
        public DateTime ListingDateTime { get; set; }
        public Property Property { get; set; }
    }
}
