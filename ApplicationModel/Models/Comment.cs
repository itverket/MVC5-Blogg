using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationModel.Models
{
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
