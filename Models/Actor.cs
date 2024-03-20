namespace Movie_Booking.Models
{
    public class Actor
    {
        public int ActorId {  get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get;set; }
        public string Bio{ get; set; }
        //one can actor can play in many movies
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
