using Movie_Booking.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Booking.Models
{
    public class Movie
    {
        [Key] public int MovieId { get; set; }
        [Required] public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public double MoviePrice { get; set; }
        //public double MovieRating{get;set;}
        public string MovieImageURL {  get; set; }
        public DateTime MovieStartDate { get; set; }
        public DateTime MovieEndDate { get; set; }
        //public double MovieDuration{get;set;}
        public Movie_Category MovieCategory { get; set; }
        //one movie can be played by multiple actors
        public List<Actor_Movie> Actors_Movies { get; set; }
        //one movie can be hosted in multiple cinemas
        public int CinemaId {  get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        //producer that produces the movie
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set;}
    }
}
