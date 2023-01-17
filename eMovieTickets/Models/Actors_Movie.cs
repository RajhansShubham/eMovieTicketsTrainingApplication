namespace eMovieTickets.Models
{
    public class Actors_Movie
    {
        public int ActorId { get; set; }

        public int MovieId { get; set; }

        public Actor Actors { get; set; }

        public Movie Movies  { get; set; }
    }
}
