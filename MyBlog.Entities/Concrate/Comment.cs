using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
       
        [Required]
        public string Content { get; set; }
        
        public DateTime CommentDate { get; set; }
        
        [Required]
        public bool Status { get; set; }
       
        public int BlogId { get; set; }
        
        public Blog Blog { get; set; }
    }
}
