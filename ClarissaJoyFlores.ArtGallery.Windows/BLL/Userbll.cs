using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarissaJoyFlores.ArtGallery.Windows.DAL;
using ClarissaJoyFlores.ArtGallery.Windows.BLL;
using ClarissaJoyFlores.ArtGallery.Windows.Helpers;
using ClarissaJoyFlores.ArtGallery.Windows.Models;
using ClarissaJoyFlores.ArtGallery.Windows.Enums;

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

        public static List<Role> GetRoles(Guid? id)
        {
            return db.UserRoles.Where(ur => ur.UserId == id).Select(ur => ur.Role).ToList();
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

        public static Operation Delete(Guid? userId)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(e => e.UserID == userId);

                if (oldRecord != null)
                {
                    db.Users.Remove(oldRecord);

                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
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

        public static Operation Deactivate(Guid? userId)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(u => u.UserID == userId);

                if (oldRecord != null)
                {


                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
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


        public static Operation UpdateUser(User newRecord)
        {
            try
            {
                User oldRecord = db.Users.FirstOrDefault(e => e.UserID == newRecord.UserID);

                if (oldRecord != null)
                {
                    oldRecord.FirstName = newRecord.FirstName;
                    oldRecord.LastName = newRecord.LastName;
                    oldRecord.Email = newRecord.Email;
                    oldRecord.Password = newRecord.Password;
                    oldRecord.Address = newRecord.Address;
                    oldRecord.ContactNumber = newRecord.ContactNumber;
                    oldRecord.Sex = newRecord.Sex;

                    db.SaveChanges();

                    return new Operation()
                    {
                        Code = "200",
                        Message = "OK"
                    };
                }


                return new Operation()
                {
                    Code = "500",
                    Message = "Not found"
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



        public static User GetById(Guid? id)
        {
            return db.Users.FirstOrDefault(u => u.UserID == id);
        }


        public static Operation Login(string emailAddress = "", string password = "")
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            if (string.IsNullOrEmpty(password))
            {
                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
                };
            }

            try
            {
                User user = db.Users.FirstOrDefault(u => u.Email.ToLower() == emailAddress.ToLower());

                if (user == null)
                {
                    return new Operation()
                    {
                        Code = "500",
                        Message = "Invalid Login"
                    };
                }

                if (password == user.Password)
                {
                    return new Operation()
                    {
                        Code = "200",
                        Message = "Successful Login",
                        ReferenceId = user.UserID
                    };
                }

                return new Operation()
                {
                    Code = "500",
                    Message = "Invalid Login"
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



            
        
    
    
