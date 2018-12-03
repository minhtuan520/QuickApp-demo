using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface IScheduleRepository : IRepository<Tkb>
    {
        List<Tkb> GetAll();
        List<Tkb> GetClassSchedule(string Hieuluc, int Id, string L);
        List<Tkb> GetTeacherSchedule(string Hieuluc, int Id, string Gv);
        List<Tkb> GetSchedule(string Hieuluc, int Id);        
    }
}
