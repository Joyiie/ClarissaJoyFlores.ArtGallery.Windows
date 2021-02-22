using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarissaJoyFlores.ArtGallery.Windows.DTO
{
    public class ArtworkDTO
    {
        [Key]
        public Guid? ArtistID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Content { get; set; }
        public string Medium { get; set; }
    }
}
