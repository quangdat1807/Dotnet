using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Todo")]
    public class Todo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order =0)]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [Display(Name= "Have you done it?")]
        public bool IsDone { get; set; } = false;
        [Required]
        public DateTime DateAdd { get; set; } = DateTime.Now;
        [Required]
        public string userId { get; set; }

    }
}
