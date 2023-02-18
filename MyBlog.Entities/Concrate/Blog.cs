using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [Required]
        public DateTime CreateDate { get; set; }
        
        [Required]
        public string ImageUrl { get; set; }
        
        [Required]
        public bool Status { get; set; }
        
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }

        public int WriterId { get; set; }
        
        public Writer Writer { get; set; }

    }
}
