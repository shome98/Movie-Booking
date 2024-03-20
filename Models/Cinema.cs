using System.ComponentModel.DataAnnotations;

namespace Movie_Booking.Models
{
    public class Cinema
    {
        [Key]public int CinemaId { get; set; }
        public string CinemaLogo {  get; set; }
        [Required] public string CinemaDescription {  get; set; }
        //one cinema can host multiple movies
        public List<Movie> Movies { get; set; }
    }
}
