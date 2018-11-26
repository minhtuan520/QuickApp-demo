using DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.Repositories
{
    public class SubjectRepository : Repository<Monhoc>, ISubjectRepository
    {
        public List<Monhoc> GetSubject()
        {
            var list = from monhoc in _appContext.Monhoc select monhoc;
            return list.ToList();
        }

        public SubjectRepository(tkbremake4DbContext context) : base(context)
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
