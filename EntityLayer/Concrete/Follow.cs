using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Follow
    {
        public int FollowId { get; set; }

        
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
