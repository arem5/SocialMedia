using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Followers
    {
        public int FollowersId { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
