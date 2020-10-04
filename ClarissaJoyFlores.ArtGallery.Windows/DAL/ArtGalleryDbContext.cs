using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClarissaJoyFlores.ArtGallery.Windows;




namespace ClarissaJoyFlores.ArtGallery.Windows.DAL
{
    public class ArtGalleryDbContext : DbContext
    {
        public ArtGalleryDbContext() : base("myConnectionString")
        {
            Database.SetInitializer(new ClarissaJoyFlores.ArtGallery.Windows.DAL.DataInitializer());
        }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Artist> Artists { get; set; }
        public DbSet<Models.Artwork> Artworks { get; set; }

    }

}
