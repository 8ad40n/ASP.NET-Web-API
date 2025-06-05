using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string CommentText { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [ForeignKey("User")]
        public string CommentedBy { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
