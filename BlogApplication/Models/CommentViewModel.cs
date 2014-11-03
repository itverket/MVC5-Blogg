using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApplication.Models
{
    public class CommentViewModel
    {
        [Required]
        public int PostId { get; set; }
        public int Id { get; set; }
        public int OwnerId { get; set; }
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}