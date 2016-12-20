using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoftUniBlog.Models
{
    public class Comment
    {
        public Comment()
        {

        }

        public Comment (string authorId, string text, int articleId)
        {
            this.AuthorId = authorId;
            this.Text = text;
            this.ArticleId = articleId;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        [ForeignKey("Article")]
        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}