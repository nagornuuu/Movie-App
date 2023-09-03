using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Shared.DTOs
{
    public class MovieFormDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }
        [Required(ErrorMessage = "Release date is required.")]
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
    }
}