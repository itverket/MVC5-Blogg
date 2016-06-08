using ApplicationModel.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PostController : ApiController
    {
        public PostModel Get(int id)
        {
            var repository = new PostRepository();

            var post = repository.GetPost(id);

            var model = new PostModel();

            if (post != null)
            {
                model = new PostModel
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Introduction = post.Introduction,
                    Content = post.Content,
                    Created = post.Created,
                    Edited = post.Edited,
                    Comments = post.Comments.Select(comment => new CommentModel
                    {
                        PostId = comment.PostId,
                        Id = comment.Id,
                        Content = comment.Content,
                        Created = comment.Created,
                        OwnerId = comment.OwnerId,
                        OwnerName = comment.OwnerName
                    }).ToList()
                };
            }

            return model;
        }

        [HttpGet]
        [Route("api/search/post/{queryString}")]
        public List<PostModel> Search(string queryString)
        {
            var repository = new PostRepository();

            var posts = repository.SearchPostTitles(queryString);

            var model = new List<PostModel>();

            if (posts != null)
            {
                foreach(var post in posts)
                {
                    model.Add(new PostModel
                    {
                        PostId = post.PostId,
                        Title = post.Title,
                        Introduction = post.Introduction,
                        Content = post.Content,
                        Created = post.Created,
                        Edited = post.Edited,
                        Comments = post.Comments.Select(comment => new CommentModel {
                            PostId = comment.PostId,
                            Id = comment.Id,
                            Content = comment.Content,
                            Created = comment.Created,
                            OwnerId = comment.OwnerId,
                            OwnerName = comment.OwnerName
                        }).ToList()
                    });
                }
            }

            return model;
        }
    }
}
