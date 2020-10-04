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
                context.SaveChanges();
        }
    }

}
