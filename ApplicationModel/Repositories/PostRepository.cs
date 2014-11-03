using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationModel.Models;

namespace ApplicationModel.Repositories
{
    public class PostRepository
    {
        private ApplicationContext _dbContext;

        public PostRepository()
        {
            _dbContext = new ApplicationContext();
        }

        public List<Post> GetAllPosts()
        {
            return _dbContext.Posts.ToList();
        }

        public void AddPost(Post post)
        {
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
        }

        public void EditPost(Post post)
        {
            var existing = _dbContext.Posts.FirstOrDefault(x => x.PostId == post.PostId);
            if (existing != null)
            {
                existing.Edited = DateTime.Now;
                existing.Title = post.Title ?? "";
                existing.Introduction = post.Introduction ?? "";
                existing.Content = post.Content ?? "";
                _dbContext.SaveChanges();
            }
        }

        public void DeletePost(Post post)
        {
            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Post> GetPostsInRange(int start, int pageSize)
        {
            return GetAllPosts().OrderByDescending(x => x.Created).ToList().Skip(start).Take(pageSize);
        }

        public Post GetPost(int id)
        {
            var post = _dbContext.Posts.FirstOrDefault(p => p.PostId == id);
            if (post != null)
            {
                post.Comments = post.Comments ?? new List<Comment>();
            }
            return post;
        }

        public void AddCommentToPost(Comment comment, int postId)
        {
            var post = GetPost(postId);
            post.Comments = post.Comments ?? new List<Comment>();
            post.Comments.Add(comment);
            _dbContext.SaveChanges();
        }

        public List<Comment> GetComments(int postId)
        {
            if (postId > 0)
            {
                return _dbContext.Comments.Where(x => x.PostId == postId).ToList();
            }
            return new List<Comment>();
        }

        public void DeleteCommentsForPost(Post post)
        {
            _dbContext.Comments.RemoveRange(_dbContext.Comments.Where(x => x.PostId == post.PostId));
            _dbContext.SaveChanges();
        }

        public void DeleteComment(int commentId)
        {
            _dbContext.Comments.Remove(_dbContext.Comments.FirstOrDefault(x => x.Id == commentId));
            _dbContext.SaveChanges();
        }

    }
}