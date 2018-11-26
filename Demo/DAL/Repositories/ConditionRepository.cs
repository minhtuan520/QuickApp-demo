using DAL.Models;
using DAL.Repositories.Interfaces;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ConditionRepository : Repository<Dieukien>, IConditionRepository
    {

        public List<Dieukien> GetCondition()
        {
            var list = from dieukien in _appContext.Dieukien select dieukien;
            return list.ToList();
        }

        public ConditionRepository(tkbremake4DbContext context) : base(context)
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
