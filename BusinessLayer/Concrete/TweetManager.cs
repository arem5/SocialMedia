using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ITweetDal _tweetDal;

        public TweetManager(ITweetDal tweetDal)
        {
            _tweetDal = tweetDal;
        }

        public void AddTweet(Tweet tweet)
        {
            _tweetDal.Insert(tweet);
        }

        public void CommentTargetUser(int userid)
        {
            throw new NotImplementedException();
        }

        public Tweet GetByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tweet> GetList() => _tweetDal.GetList();

        public void TweetDelete(Tweet tweet)
        {
            _tweetDal.Delete(tweet);
        }
    }
}
