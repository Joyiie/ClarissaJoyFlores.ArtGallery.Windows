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
    public static class Userbll
    {

        private static ArtGalleryDbContext db = new ArtGalleryDbContext();

        public static Paged<Models.User> Search(int pageIndex = 1, int pageSize = 1, string sortBy = "lastname", string sortOrder = "asc", string assignment = "", string status = "", string keyword = "")
        {
            IQueryable<User> allUsers = (IQueryable<User>)db.Users;
            Paged<Models.User> users = new Paged<Models.User>();


            if (!string.IsNullOrEmpty(keyword))
            {
                allUsers = allUsers.Where(e => e.FirstName.Contains(keyword) || e.LastName.Contains(keyword));
            }

            var queryCount = allUsers.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUsers.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "desc")
            {
                users.Items = allUsers.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }


            else if (sortBy.ToLower() == "lastname" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUsers.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                users.Items = allUsers.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }
            users.PageCount = pageCount;
            users.QueryCount = queryCount;
            users.PageIndex = pageIndex;
            users.PageSize = pageSize;

            return users;
        }

        public static Operation Add(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();

                return new Operation()
                {
                    Code = "200",
                    Message = "Ok",
                    ReferenceId = user.UserID
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



            
        
    
    
