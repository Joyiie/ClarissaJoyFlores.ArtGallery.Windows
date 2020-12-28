using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarissaJoyFlores.ArtGallery.Windows.DAL;
using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.Helpers;
using ClarissaJoyFlores.ArtGallery.Windows.Models;

namespace ClarissaJoyFlores.ArtGallery.Windows.BLL
{
    public static class Artistbll
    {

        private static ArtGalleryDbContext db = new ArtGalleryDbContext();

        public static Paged<Models.Artist> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "Name", string sortOrder = "asc", string assignment = "", string status = "", string keyword = "")
        {
            IQueryable<Artist> allArtist = (IQueryable<Artist>)db.Artists;
            Paged<Models.Artist> artist = new Paged<Models.Artist>();


            if (!string.IsNullOrEmpty(keyword))
            {
                allArtist = allArtist.Where(e => e.Name.Contains(keyword));
            }

            var queryCount = allArtist.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "asc")
            {
                artist.Items = allArtist.OrderBy(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "name" && sortOrder.ToLower() == "desc")
            {
                artist.Items = allArtist.OrderByDescending(e => e.Name).Skip(skip).Take(pageSize).ToList();
            }


            else if (sortBy.ToLower() == "styleofwork" && sortOrder.ToLower() == "asc")
            {
               artist.Items = allArtist.OrderBy(e => e.StyleOfWork).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
               artist.Items = allArtist.OrderByDescending(e => e.StyleOfWork).Skip(skip).Take(pageSize).ToList();
            }
            artist.PageCount = pageCount;
            artist.QueryCount = queryCount;
            artist.PageIndex = pageIndex;
            artist.PageSize = pageSize;

            return artist;

        }

        public static Operation Add(Artist artist)
        {
            try
            {
                db.Artists.Add(artist);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = artist.ArtistID
                };
            }

            catch ( Exception e)
            {
                return new Operation()
                {
                    Code = "500",
                    Message = e.Message
                };
            }
        }
    }
}
