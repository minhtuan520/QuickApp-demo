using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface ISubjectRepository: IRepository<Monhoc>
    {
        List<Monhoc> GetSubject();
        bool DeleteSubject();
    }
}
