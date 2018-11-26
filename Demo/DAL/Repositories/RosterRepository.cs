using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.Repositories
{
    public class RosterRepository : Repository<Phancong>, IRosterRepository
    {
        public List<Phancong> GetRoster()
        {
            var list = from bangphancong in _appContext.Phancong select bangphancong;
            return list.ToList();
        }

        public RosterRepository(tkbremake4DbContext context) : base(context)
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
