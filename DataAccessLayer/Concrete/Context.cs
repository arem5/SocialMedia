using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext // Add Entity Framework
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Retweet> Retweets { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Followers> Followers { get; set; }

        // make sql connection on appsettings and startup
    }
}
