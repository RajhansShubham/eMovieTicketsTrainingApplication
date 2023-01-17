using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace eMovieTickets.Models
{
    public class Cinemas
    {
        [Key]
        public int Id { get; set; }

        public string  Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [NotMapped]
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
