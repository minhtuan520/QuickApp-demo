using DAL.Models;
using DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class TeacherRepository : Repository<Giaovien>, ITeacherRepository
    {

        public List<Giaovien> GetTeacher()
        {
            var list = from giaovien in _appContext.Giaovien select giaovien;
            return list.ToList();
        }

        public TeacherRepository(tkbremake4DbContext context) : base(context)
        {
        }
        private tkbremake4DbContext _appContext
        {
            get
            {
                return (tkbremake4DbContext)_context;
            }
        }
    }
}
