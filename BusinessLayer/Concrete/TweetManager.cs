using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TweetManager : ITweetService
    {
        public void AddTweet(Tweet tweet)
        {
            throw new NotImplementedException();
        }

        public void CommentTargetUser(int userid)
        {
            throw new NotImplementedException();
        }

        public Tweet GetByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tweet> GetList()
        {
            throw new NotImplementedException();
        }

        public void TweetDelete(Tweet tweet)
        {
            throw new NotImplementedException();
        }
    }
}
