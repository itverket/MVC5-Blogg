using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApplicationModel.Models;
using BlogApplication.Models;

namespace BlogApplication.Extensions
{
    public static class CommentExtensions
    {
        public static IEnumerable<CommentViewModel> GetMapping(this IEnumerable<Comment> comments)
        {
            return comments.Select(x => x.GetMapping());
        }  

        public static  CommentViewModel GetMapping(this Comment comment)
        {
            return new CommentViewModel
            {
                Content = comment.Content,
                Created = comment.Created,
                Id = comment.Id,
                OwnerName = comment.OwnerName,
                PostId = comment.PostId
            };
        }
    }
}