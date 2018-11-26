using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ClassRepository : Repository<Lop>, IClassRepository
    {      
        public List<Lop> GetClass()
        {
            var list = from lop in _appContext.Lop select lop;
            return list.ToList();
        }

        public ClassRepository(tkbremake4DbContext context) : base(context)
        { }

        private tkbremake4DbContext _appContext
        {
            get
            {
                return (tkbremake4DbContext)_context;
            }
        }

        //public List<Lop> GetAllClassData(int page)
        //{           
        //    var list = from lop in _appContext.Lop select lop;
        //    var onePageOfProducts = list.ToPagedList(page, 2);
        //    return onePageOfProducts.ToList();

        //}

        public bool AddClass(string lop)
        {
            bool flag = false;
            Lop lopModel = new Lop();
            lopModel.L = lop;
            _appContext.Lop.Add(lopModel);
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

        public bool DeleteClass()
        {
            try
            {
                _appContext.RemoveRange(from lop in _appContext.Lop select lop);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
