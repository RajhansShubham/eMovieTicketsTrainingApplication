using System.ComponentModel.DataAnnotations;

namespace eMovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }


        //Relationship

        public List<Actors_Movie> Actors_Movies { get; set; }
    }
}
