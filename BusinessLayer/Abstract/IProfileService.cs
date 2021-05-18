using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IProfileService
    {
        void AddProfile(int userid);
        void AddInfo (Profile profile);
        Profile GetById(int profileid);
        void ProfileUpdate(Profile profile);

    }
}
