using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class ScheduleRepository : Repository<Tkb>, IScheduleRepository
    {
        #region Constructer

        public ScheduleRepository(tkbremake4DbContext context) : base(context)
        {
        }
        private tkbremake4DbContext _appContext
        {
            get
            {
                return (tkbremake4DbContext)_context;
            }
        }

        #endregion
        #region Function
        public List<Tkb> GetClassSchedule(string Hieuluc, int Id, string L)
        {
            throw new NotImplementedException();
        }

        public List<Tkb> GetSchedule(string Hieuluc, int Id)
        {
            throw new NotImplementedException();
        }

        public List<Tkb> GetTeacherSchedule(string Hieuluc, int Id, string Gv)
        {
            throw new NotImplementedException();
        }

        public List<Tkb> GetAll()
        {



            throw new NotImplementedException();
        } 
        #endregion
    }
}
