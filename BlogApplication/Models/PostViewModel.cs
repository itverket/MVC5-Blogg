using System;
using System.Collections.Generic;
using ApplicationModel.Models;

namespace BlogApplication.Models
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; } 
    }
}