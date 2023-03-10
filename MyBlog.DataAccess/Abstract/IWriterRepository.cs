using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Abstract
{
    public interface IWriterRepository : IGenericRepository<Writer>
    {
        Writer LoginCheck(Writer writer);
    }
}
