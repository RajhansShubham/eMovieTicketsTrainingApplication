using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace eMovieTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display( Name = "Actor Name")]
        public string Name { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }


        //Relationship

        public List<Actors_Movie> Actors_Movies { get; set; }
    }
}
