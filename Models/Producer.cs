namespace Movie_Booking.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        //one producer can produce multiple movies
        public List<Movie> Movies { get; set; }
    }
}
