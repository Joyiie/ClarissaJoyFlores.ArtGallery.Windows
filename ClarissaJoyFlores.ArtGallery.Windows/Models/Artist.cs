using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClarissaJoyFlores.ArtGallery.Windows.Models
{
   public class Artist
    { 
        [Key] public Guid? ArtistID { get; set; }
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public string Age { get; set; }
        public string StyleOfWork { get; set; }
    }
}
