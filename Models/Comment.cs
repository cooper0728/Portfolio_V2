﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Portfolio_v2.Models;

namespace Portfolio_v2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        [Required]
        public string Body { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual Post Post { get; set; }



    }
}