using System;
using System.ComponentModel.DataAnnotations;

namespace Dotnetimals
{
    public class Cat
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Colour { get; set; }

        [Range(0,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public DateTime Birthdate { get; set; }
        public string FavouriteDish { get; set; }

    }
}