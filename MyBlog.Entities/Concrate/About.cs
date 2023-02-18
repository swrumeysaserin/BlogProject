using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Detail1 { get; set; }
        
        public string Detail2 { get; set; }
        
        [Required]
        public string ImageUrl1 { get; set; }
        
        public string ImageUrl2 { get; set; }
        
        [Required]
        public string MapLocation { get; set; }
       
        [Required]
        public bool Status { get; set; }
    }
}