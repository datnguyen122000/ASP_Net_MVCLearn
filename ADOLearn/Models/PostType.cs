using System.Collections.Generic;

namespace ADOLearn.Models
{
    public class PostType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}