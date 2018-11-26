﻿// ====================================================
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
        #region declare
        readonly tkbremake4DbContext _context;

        private IClassRepository _class;
        private ISubjectRepository _subject;
        private ITeacherRepository _teacher;
        private IRosterRepository _roster;
        private IConditionRepository _condition;
        #endregion

        public UnitOfWork(tkbremake4DbContext context)
        {
            _context = context;
        }
        #region extract

        public IClassRepository Lop
        {
            get
            {
                if (_class == null)
                    _class = new ClassRepository(_context);

                return _class;
            }
        }
        public ISubjectRepository MonHoc
        {
            get
            {
                if (_subject == null)
                    _subject = new SubjectRepository(_context);

                return _subject;
            }
        }
        public IRosterRepository PhanCong
        {
            get
            {
                if (_roster == null)
                    _roster = new RosterRepository(_context);

                return _roster;
            }
        }
        public ITeacherRepository GiaoVien
        {
            get
            {
                if (_teacher == null)
                    _teacher = new TeacherRepository(_context);

                return _teacher;
            }
        }
        public IConditionRepository DieuKien
        {
            get
            {
                if (_condition == null)
                    _condition = new ConditionRepository(_context);

                return _condition;
            }
        }
        #endregion

        //public int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}
    }
}
