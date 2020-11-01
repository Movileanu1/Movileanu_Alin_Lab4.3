using System;
using System.ComponentModel.DataAnnotations;

namespace Movileanu_Alin_Lab3.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int BookCount { get; set; }
    }
}