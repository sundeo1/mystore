using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mystore.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string LongDescription { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }
        [Required]
        [Url]
        public string ImageThumbnailUrl { get; set; }
        [Required]
        public bool IsPreferredProduct { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public virtual Category Category { get; set; }
    }
}
