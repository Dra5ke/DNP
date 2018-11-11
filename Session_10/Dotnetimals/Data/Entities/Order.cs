using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnetimals
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        
        [NotMapped]
        public ICollection Items { get; set; }
    }
}