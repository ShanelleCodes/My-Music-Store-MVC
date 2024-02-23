using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MusicStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SongName { get; set; }
        [Required]
        public string Artist {  get; set; }
        [Required]
        //public string Genre { get; set; }
        public string Album { get; set; }

        [Range(.50,50)]
        public double Price { get; set; }
        
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl {  get; set; }


    }
}
