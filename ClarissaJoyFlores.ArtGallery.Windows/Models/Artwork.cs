using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClarissaJoyFlores.ArtGallery.Windows.Models
{
    public class Artwork
    {
        [Key] public Guid? ArtistID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Content { get; set; }
        public string Medium { get; set; }
    }
}
