using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserMail { get; set; }
        
        public string CommentContent { get; set; }

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public int PostID { get; set; }
        public virtual Post Post { get; set; }
    }
}
