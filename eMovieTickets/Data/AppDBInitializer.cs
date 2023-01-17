using eMovieTickets.Models;
using Microsoft.Win32.SafeHandles;
using System.Net.WebSockets;

namespace eMovieTickets.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                bool flag = false;

                //Initializing Cinema
                if (!context.Cinemas.Any())
                {                   
                    context.Cinemas.AddRange
                         (
                        new Cinemas
                        {
                            Name = "Ved",
                            Description = "",
                            Logo = "https://www.google.co.in/imgres?imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA%40%40._V1_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0325980%2F&tbnid=zoGaBhBrWtkfNM&vet=12ahUKEwiKpeH09838AhWYhNgFHSg_DpUQMygAegUIARDeAQ..i&docid=HG_xw0MaqI0HOM&w=1114&h=1650&q=pirates%20of%20the%20caribbean&ved=2ahUKEwiKpeH09838AhWYhNgFHSg_DpUQMygAegUIARDeAQ"
                        },
                        new Cinemas
                        {
                            Description = "",
                            Name = "Pirates of Carreabean",
                            Logo = "https://www.google.co.in/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2Fc%2Fc3%2FVed_film_poster.jpg%2F220px-Ved_film_poster.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FVed_(film)&tbnid=K4s8r-W689gARM&vet=12ahUKEwih9qjm9838AhWR_XMBHWgFD9QQMygAegUIARDLAQ..i&docid=OHo4PhxrtxiqNM&w=220&h=318&q=ved%20movie&ved=2ahUKEwih9qjm9838AhWR_XMBHWgFD9QQMygAegUIARDLAQ",
                        }
                        );
                         flag = true;
                }

                //Initializing Actors
                if(!context.Actors.Any())
                {
                    context.Actors.Add(
                        new Actor
                        {
                           Name = "Retiesh Deshmukh",
                           Bio = "Romantic and comedy actor",
                           ProfilePictureURL = "https://www.google.co.in/imgres?imgurl=https%3A%2F%2Fassets-in.bmscdn.com%2Fiedb%2Fartist%2Fimages%2Fwebsite%2Fposter%2Flarge%2Friteish-deshmukh-25378-13-09-2017-04-40-50.jpg&imgrefurl=https%3A%2F%2Fin.bookmyshow.com%2Fperson%2Friteish-deshmukh%2F25378&tbnid=79qkOBGwpqD98M&vet=12ahUKEwiPgLyF_c38AhUgILcAHeu7C7gQMygEegUIARDrAQ..i&docid=DDNj2f_qNrinuM&w=204&h=204&q=riteish%20deshmukh&ved=2ahUKEwiPgLyF_c38AhUgILcAHeu7C7gQMygEegUIARDrAQ"
                        });
                    flag = true;
                }

                // initializing Producers
                if (!context.Producer.Any())
                {
                    context.Producer.Add(
                        new Producer
                        {
                            Name = "sallu Bhai",
                            ProfilePictureURL = "",
                            Bio = "Actor/ Producer"
                        });
                    flag = true;
                }
                //Movies
                //Actors and Movies


                if(flag) 
                    context.SaveChanges();
            }
        }
    }
}
