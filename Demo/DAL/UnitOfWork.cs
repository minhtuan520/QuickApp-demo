// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Repositories.Interfaces;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        //readonly ApplicationDbContext _context;
        readonly tkbremake4DbContext _context;
      
        private IClassRepository _class;


        public UnitOfWork(tkbremake4DbContext context)
        {
            _context = context;
        }

        public IClassRepository Lop 
        {
            get
            {
                if (_class == null)
                    _class = new ClassRepository(_context);

                return _class;
            }
        }
        
        //public int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}
    }
}
