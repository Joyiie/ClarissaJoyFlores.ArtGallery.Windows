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
    public static class Artworkbll
    {

        private static ArtGalleryDbContext db = new ArtGalleryDbContext();

        public static Paged<Models.Artwork> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "title", string sortOrder = "asc", string assignment = "", string status = "", string keyword = "")
        {
            IQueryable<Artwork> allArtworks = (IQueryable<Artwork>)db.Artworks;
            Paged<Models.Artwork> artworks = new Paged<Models.Artwork>();


            if (!string.IsNullOrEmpty(keyword))
            {
                allArtworks = allArtworks.Where(e => e.Title.Contains(keyword));
            }

            var queryCount = allArtworks.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "asc")
            {
                artworks.Items = allArtworks.OrderBy(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "title" && sortOrder.ToLower() == "desc")
            {
                artworks.Items = allArtworks.OrderByDescending(e => e.Title).Skip(skip).Take(pageSize).ToList();
            }


            else if (sortBy.ToLower() == "year" && sortOrder.ToLower() == "asc")
            {
                artworks.Items = allArtworks.OrderBy(e => e.Year).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                artworks.Items = allArtworks.OrderByDescending(e => e.Year).Skip(skip).Take(pageSize).ToList();
            }
            artworks.PageCount = pageCount;
            artworks.QueryCount = queryCount;
            artworks.PageIndex = pageIndex;
            artworks.PageSize = pageSize;

            return artworks;
        }

        public static Operation Add(Artwork artwork)
        {
            try
            {
                db.Artworks.Add(artwork);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = artwork.ArtistID
                };
            }

            catch (Exception e)
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
