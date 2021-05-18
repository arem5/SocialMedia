using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public string ProfileImage { get; set; }
        public DateTime DateProfileCreated { get; set; }


        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
