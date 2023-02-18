using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrate
{
    public class Subscriber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string Email { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
