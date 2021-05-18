using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }


        public ICollection<Tweet> Tweets { get; set; }
        public ICollection<Retweet> Retweets { get; set; }
        public ICollection<Like> Likes { get; set; }

    }
}
