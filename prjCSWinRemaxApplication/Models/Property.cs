using System;
using System.Windows;
using prjCSWinRemaxApp.Models;

namespace prjCSWinRemaxApp.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public Address Address { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public long Size { get; set; }

        public PropertyStatus PropertyStatus { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}