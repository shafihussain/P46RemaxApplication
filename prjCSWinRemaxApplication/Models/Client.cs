using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCSWinRemaxApp.Models;

namespace prjCSWinRemaxApp.Models
{
    public class Client : Person
    {
        public int ClientId { get; set; }
        public string Status { get; set; }//Buyer ? or Seller?
    }
}
