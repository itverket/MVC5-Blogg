using System.Collections.Generic;

namespace BlogApplication.Models
{
    public class ViewPostsViewModel
    {
        public ViewPostsViewModel()
        {
            Posts = new List<PostViewModel>();
        }
        public List<PostViewModel> Posts { get; set; }
        public int CurrentPos { get; set; }
        public bool PrevPageExists { get; set; }
        public bool NextPageExists { get; set; }
    }
}