using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Required]
        public string UserMessage { get; set; }
        
        [Required]
        public DateTime ContactDate { get; set; }
        
        [Required]
        public bool Status { get; set; }
    }
}
