using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Booky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1000, 1000000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1000-200000")]
        [Range(1000, 1000000)]
        public double Price { get; set; }


        [Required]
        [Display(Name = "Price for 200000+")]
        [Range(1000, 1000000)]
        public double Price200 { get; set; }

        [Required]
        [Display(Name = "Price for 500000+")]
        [Range(1000, 1000000)]
        public double Price500 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
