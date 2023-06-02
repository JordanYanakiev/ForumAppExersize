using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static ForumApp03Infrastructure.Data.DataConstants;

namespace ForumApp03.Models.Post
{
    public class PostFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
