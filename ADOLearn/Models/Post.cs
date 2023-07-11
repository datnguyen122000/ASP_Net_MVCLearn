using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public string PostWriter { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public bool Display { get; set; }
        public int OrderNumber { get; set; }
        public int IdType { get; set; }
        public virtual PostType PostType { get; set; }
    }
}