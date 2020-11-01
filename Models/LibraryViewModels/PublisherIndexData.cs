using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movileanu_Alin_Lab3.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
