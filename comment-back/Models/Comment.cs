using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace comment_back.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Creator { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
    }
}
