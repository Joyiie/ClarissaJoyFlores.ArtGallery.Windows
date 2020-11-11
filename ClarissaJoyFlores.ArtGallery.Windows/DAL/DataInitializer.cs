using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarissaJoyFlores.ArtGallery.Windows.DAL
{
   public class DataInitializer  : System.Data.Entity.DropCreateDatabaseAlways<ArtGalleryDbContext>
    {
     protected override void Seed(ArtGalleryDbContext context) 
        {
            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8440"),
                FirstName = "Joy",
                LastName = "Ching",
                Address = "Luacan",
                Sex = "Female",
                ContactNumber = "09452294737",
                Email = "joyching@gmail.com",
                Password = "joyiie",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8441"),
                FirstName = "Joyjoy",
                LastName = "Cheng",
                Address = "Magsaysay",
                Sex = "Female",
                ContactNumber = "09452293737",
                Email = "joyjoycheng@gmail.com",
                Password = "joycheng",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8442"),
                FirstName = "Joyie",
                LastName = "Chan",
                Address = "Maite",
                Sex = "Female",
                ContactNumber = "09453293737",
                Email = "joyiechan@gmail.com",
                Password = "joyiechan",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8443"),
                FirstName = "Joyce",
                LastName = "Charm",
                Address = "Culo",
                Sex = "Female",
                ContactNumber = "09462294737",
                Email = "joyching@gmail.com",
                Password = "joyce",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8444"),
                FirstName = "Jocel",
                LastName = "Chua",
                Address = "HappyValley",
                Sex = "Male",
                ContactNumber = "09452254737",
                Email = "jocelchua@gmail.com",
                Password = "jocel",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8445"),
                FirstName = "Jace",
                LastName = "Ching",
                Address = "Pinulot",
                Sex = "Male",
                ContactNumber = "09452294747",
                Email = "jaceching@gmail.com",
                Password = "jace",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8446"),
                FirstName = "Charie",
                LastName = "Huang",
                Address = "Lincoln",
                Sex = "Female",
                ContactNumber = "09452694737",
                Email = "CharieHuang@gmail.com",
                Password = "huang",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8447"),
                FirstName = "Chester",
                LastName = "Chong",
                Address = "Dinalupihan",
                Sex = "Male",
                ContactNumber = "09352294737",
                Email = "chesterchong@gmail.com",
                Password = "chester",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8448"),
                FirstName = "Jezter",
                LastName = "Howard",
                Address = "San Ramon",
                Sex = "Male",
                ContactNumber = "09452894737",
                Email = "jezterhoward@gmail.com",
                Password = "howard",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8449"),
                FirstName = "Cloe",
                LastName = "Changen",
                Address = "Pita",
                Sex = "Female",
                ContactNumber = "09452295737",
                Email = "cloechangen@gmail.com",
                Password = "changen",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8410"),
                FirstName = "Halie",
                LastName = "Chua",
                Address = "San Jose",
                Sex = "Male",
                ContactNumber = "09452104737",
                Email = "haliechua@gmail.com",
                Password = "halie",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8411"),
                FirstName = "Charlie",
                LastName = "Hing",
                Address = "Bodega",
                Sex = "Male",
                ContactNumber = "09415294737",
                Email = "charliehing@gmail.com",
                Password = "charlie",


            });


            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8412"),
                FirstName = "Charm",
                LastName = "Cheng",
                Address = "Balanga",
                Sex = "Female",
                ContactNumber = "09415544737",
                Email = "charmcheng@gmail.com",
                Password = "charm",


            });


            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8413"),
                FirstName = "Jess",
                LastName = "Lustrio",
                Address = "Orani",
                Sex = "Male",
                ContactNumber = "09410294737",
                Email = "jesslustrio@gmail.com",
                Password = "lustrio",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8414"),
                FirstName = "Brill",
                LastName = "Flores",
                Address = "",
                Sex = "Male",
                ContactNumber = "09415245737",
                Email = "brillflores@gmail.com",
                Password = "flores",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8415"),
                FirstName = "Justine",
                LastName = "Nuguiat",
                Address = "",
                Sex = "Male",
                ContactNumber = "09415294767",
                Email = "justinenuguiat@gmail.com",
                Password = "justine",


            });

            context.Users.Add(new Models.User()
            {



                UserID = Guid.Parse("4f05bb73-93a3-44d8-bbd9-c0475e9c8416"),
                FirstName = "Clarence",
                LastName = "C",
                Address = "",
                Sex = "Male",
                ContactNumber = "09415294737",
                Email = "@gmail.com",
                Password = "",


            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b11f"),
                Name = "Leonardo Da Vinci",
                BirthPlace = "Italy",
                Age = "52",
                StyleOfWork = "Renaissance man, Universal Genius, Unquenchable curiosity, Feverishly Inventive Imagination",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b11f"),
                Title = "Mona Lisa",
                Year = "c. 1503–19",
                Content = "Sitter’s mysterious gaze and enigmatic smile.",
                Medium = "oil on wood panel",

            });



            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b12f"),
                Name = "Pablo Picasso",
                BirthPlace = "Spain",
                Age = "85",
                StyleOfWork = "Drawing, Painting, Cerematic, Sculpture, Printmaking, Writing, Stage Design",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b12f"),
                Title = "The Old Guitarist",
                Year = "1903",
                Content = "The Man with the Blue Guitar",
                Medium = " oil painting ",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b13f"),
                Name = "Vincent van Gogh",
                BirthPlace = "Nethelands",
                Age = "95",
                StyleOfWork = "Biography, Painting, Drawing",
            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b13f"),
                Title = "The Yellow House",
                Year = "1888",
                Content = "",
                Medium = "Oil on canvas",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b14f"),
                Name = "Cloude Monet",
                BirthPlace = "France",
                Age = "96",
                StyleOfWork = "Drawing, Painting, Sculpture, Printmaking",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b14f"),
                Title = "Impression, Sunrise",
                Year = "1872",
                Content = "It was intended as disparagement but the Impressionists appropriated the term for themselves",
                Medium = "Oil on canvas",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b15f"),
                Name = "Rembrandt",
                BirthPlace = "Netherlands",
                Age = "95",
                StyleOfWork = "Drawing, Painting, Sculpture, Printmaking, Biography",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b15f"),
                Title = "The Prodigal Son in the Brothel",
                Year = "1637",
                Content = " two people who had been identified as Rembrandt himself and his wife Saskia",
                Medium = "Oil on Cnvas",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b16f"),
                Name = "Michelangelo",
                BirthPlace = "Italy",
                Age = "98",
                StyleOfWork = "Painting, Sculpture, Poetry, Architecture",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b16f"),
                Title = "The Last Judgment",
                Year = "1536–1541",
                Content = " It is a depiction of the Second Coming of Christ and the final and eternal judgment by God of all humanity. The dead rise and descend to their fates, as judged by Christ who is surrounded by prominent saints",
                Medium = "Orange, green, yellow, and blue are scattered throughout, animating and unifying the complex scene.",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b17f"),
                Name = "Jackson Pollock",
                BirthPlace = "United State",
                Age = "92",
                StyleOfWork = "Drawing, Painting, Biography, Abstract",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b17f"),
                Title = "The Deep",
                Year = "1953",
                Content = "There are many interpretations on the meaning of the painting, and the painting's name, most often as a deep and profound void or hole, a viscous cut, or a dying man",
                Medium = "combination of dripping black and white paints, only to break it down with touches of yellow",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b18f"),
                Name = "Marcel Duchamp",
                BirthPlace = "France",
                Age = "97",
                StyleOfWork = "Painting, Sculpture, Writer, Ches Player",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b18f"),
                Title = "Nude Descending a Staircase, No. 2 ",
                Year = "1912",
                Content = "sad young man who is in a corridor and who is moving about; thus there are two parallel movements corresponding to each other",
                Medium = "Oil on canvas",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b19f"),
                Name = "Paul Cezanne",
                BirthPlace = "France",
                Age = "91",
                StyleOfWork = "Drawing, Painting",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b19f"),
                Title = "The Bathers",
                Year = "1898–1905",
                Content = "treat nature in terms of the cylinder, the sphere and the cone",
                Medium = "Oil-on-canvas",

            });

            context.Artists.Add(new Models.Artist()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b20f"),
                Name = "Caravaggio",
                BirthPlace = "Italy",
                Age = "94",
                StyleOfWork = "Drawing, Painting, Biography",

            });

            context.Artworks.Add(new Models.Artwork()
            {
                ArtistID = Guid.Parse("c8bd6bfd-43df-4d36-930b-463bc154b20f"),
                Title = "The Musicians",
                Year = "1595",
                Content = "painted for the Cardinal youths playing music very well drawn from nature and also a youth playing a lute",
                Medium = "Oil on canvas",

            });

            context.SaveChanges();
        }
    }

}
