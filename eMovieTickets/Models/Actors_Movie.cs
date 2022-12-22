namespace eMovieTickets.Models
{
    public class Actors_Movie
    {
        public int ActorId { get; set; }

        public int MovieId { get; set; }

        public Actor Actor { get; set; }

        public Movie Movie  { get; set; }
    }
}
