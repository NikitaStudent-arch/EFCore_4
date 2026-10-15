using EFCore_4;
using EFCore_4.Models;
using Microsoft.Identity.Client;

namespace EFCore_4
{
    public class Program
    {
        public List<User> ReadUsers()
        {
            using (var db = new BlogDbContext())
            {
                return db.Users.ToList();
            }
        }

        public void UpdateUser(int id, string name, string email)
        {
            using (var db = new BlogDbContext())
            {
                var user = db.Users.Find(id);
                if (user != null)
                {
                    user.Name = name;
                    user.Email = email;
                    db.SaveChanges();
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (var db = new BlogDbContext())
            {
                var user = db.Users.Find(id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }
        }

        public int CreateUser(string name, string email)
        {
            using (var db = new BlogDbContext())
            {
                var user = new User { Name = name, Email = email };
                db.Users.Add(user);
                db.SaveChanges();
                return user.Id;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}

