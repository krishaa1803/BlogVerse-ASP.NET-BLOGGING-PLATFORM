using System.ComponentModel.DataAnnotations;

namespace BlogVerse.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Views { get; set; }

        public int Likes { get; set; }
    }
}
