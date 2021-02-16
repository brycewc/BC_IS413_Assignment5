using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public String Publisher { get; set; }
        [Required]
        //Regular Expression to validate entered ISBN Numbers of either 10 or 13 characters, including section dashes
        [RegularExpression("^(?:ISBN(?:-13)?:?\\ )?(?=[0-9]{13}$|(?=(?:[0-9]+[-\\ ]){4})[-\\ 0-9]{17}$)97[89][-\\ ]?[0-9]{1,5}[-\\ ]?[0-9]+[-\\ ]?[0-9]+[-\\ ]?[0-9]$", ErrorMessage = "Must be a valid ISBN number in format and 10 or 13 digits")]
        public String ISBN { get; set; }
        [Required]
        public String Classification { get; set; }
        [Required]
        public String Category { get; set; }
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "Must be valid monetary value")]
        public double Price { get; set; }
    }
}
