using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [Required]
        public string WriterEmail { get; set; }

        [Required]
        public string WriterPassword { get; set; }

        public string WriterFullName { get; set; }
        [Required]
        public string WriterNickName { get; set; }

        public string PicturePath { get; set; }
        public DateTime LastLogin { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
