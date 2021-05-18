using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Retweet
    {
        [Key]
        public int RetweetId { get; set; }

        
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        
        public int? TweetId { get; set; }
        [ForeignKey("TweetId")]
        public virtual Tweet Tweet { get; set; }
    }
}
