using EFCore_4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4.Services
{
    public interface IBlogService
    {
        //User
        public void AddUser(User user);
        public List<User> GetUsers();
        public User GetUserById(int id);
        public void UpdateUser(User user);
        public void DeleteUser(int id);

        //Profile
        public void AddProfile(Profile profile);
        public Profile GetProfileById(int userId);

        //Post
        public void AddPost(Post post);
        public List<Post> GetPosts();
        public Post UpdatePost(Post post);
        public void DeletePost(int id);
    }

    public class BlogService : IBlogService
    {
        private readonly BlogDbContext _context;
        public BlogService(BlogDbContext context)
        {
            _context = context;
        }
        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void AddProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Profile GetProfileById(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User? GetUsers(int id)
            =>
            _context.Users
            .Include(u => u.Posts)
            .Include(u => u.Profile)
            .FirstOrDefault(u => u.Id == id);

        public Post UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
