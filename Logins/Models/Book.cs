using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logins.Models
{
    public class Book
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int NumberOfPages  { get; set; }
        public string PublishingCompany { get; set; }
        public double Price { get; set; }
    }
}
