using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
       
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        public string Detail { get; set; }
        
        [Required]
        public bool Status { get; set; }
        

    }
}
