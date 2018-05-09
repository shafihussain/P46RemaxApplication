using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCSWinRemaxApp.Models;

namespace prjCSWinRemaxApp.Models
{
    public class Agent : Person
    {
        public int AgentId { get; set; }

        public PropertyListing PropertyListing { get; set; }

    }
}
