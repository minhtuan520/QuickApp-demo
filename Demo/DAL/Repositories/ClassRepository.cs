using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ClassRepository : Repository<Lop>, IClassRepository
    {
        public ClassRepository(tkbremake4DbContext context) : base(context)
        { }

        private tkbremake4DbContext _appContext
        {
            get
            {
                return (tkbremake4DbContext)_context;
            }
        }

        public IEnumerable<Lop> GetAllClassData()
        {

            return _appContext.Lop
                .OrderBy(l => l.L)
                .ToList();
        }

        public bool AddClass(Lop lop)
        {
            bool flag = false;
            _appContext.Lop.Add(lop);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;                
            }
            flag = true;
            return flag;
        }
    }
}
