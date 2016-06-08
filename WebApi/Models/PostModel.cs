using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public class PostModel
    {
        public PostModel()
        {
            Comments = new List<CommentModel>();
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }

        public List<CommentModel> Comments { get; set; }
    }

    public class CommentModel
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}