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
    public class WriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        Context _database;
        public WriterRepository(Context database) : base(database)
        {
            _database = database;
        }

        public Writer LoginCheck(Writer writer)
        {
            var checkedUser = _database.Writers.FirstOrDefault(wrt => wrt.Email == writer.Email &&
                                                              wrt.Password == writer.Password);
            return checkedUser;
        }
    }
}