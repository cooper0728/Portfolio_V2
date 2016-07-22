using Portfolio.Models.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class SearchResult
    {
        public virtual Post Title { get; set; }
        public virtual Post Body { get; set; }
        public string Abstract { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        
    }
}