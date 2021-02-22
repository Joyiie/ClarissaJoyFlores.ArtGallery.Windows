using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarissaJoyFlores.ArtGallery.Windows.DTO
{
    public class ArtistDTO
    {
        [Key]
        public Guid? ArtistID { get; set; }
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public string Age { get; set; }
        public string StyleOfWork { get; set; }
    }
}
