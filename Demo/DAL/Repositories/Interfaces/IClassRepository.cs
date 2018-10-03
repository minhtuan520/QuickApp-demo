using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface IClassRepository : IRepository<Lop>
    {       
        List<Lop> GetAllClassData();
        bool AddClass(string lop);
    }
}
