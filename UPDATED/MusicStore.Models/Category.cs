using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,1000,ErrorMessage ="Display Order Must Be Between 1 & 1000")]
        public int DisplayOrder { get; set; }
    }
}
