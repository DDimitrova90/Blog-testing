using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftUniBlog.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public string AuthorId { get; set; }

        public int ArticleId { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}