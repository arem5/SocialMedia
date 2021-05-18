using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tweet
    {
        [Key]
        public int TweetId { get; set; }
        [StringLength(140)]
        public string Content { get; set; }
        public string? Media { get; set; }        
        public DateTime TweetDate { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public ICollection<Retweet> Retweets { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
