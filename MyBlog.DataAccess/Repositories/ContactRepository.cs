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
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(Context database) : base(database)
        {
        }
    }
}
