using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITweetService
    {
        List<Tweet> GetList();
        void AddTweet(Tweet tweet);
        Tweet GetByUserId(int id);
        void TweetDelete(Tweet tweet);
        void CommentTargetUser(int userid);

    }
}
