using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrate;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Repositories
{
    public class SubscriberRepository : GenericRepository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(Context database) : base(database)
        {
        }
    }
}
