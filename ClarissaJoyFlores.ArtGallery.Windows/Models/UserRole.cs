using ClarissaJoyFlores.ArtGallery.Windows.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarissaJoyFlores.ArtGallery.Windows.Models
{
    public  class UserRole
    {
        public Guid? Id { get; set; }

        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
