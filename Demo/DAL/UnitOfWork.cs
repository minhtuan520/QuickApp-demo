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

        //ICustomerRepository _customers;
        //IProductRepository _products;
        //IOrdersRepository _orders;
        IClassRepository _class;


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



        //public ICustomerRepository Customers
        //{
        //    get
        //    {
        //        if (_customers == null)
        //            _customers = new CustomerRepository(_context);

        //        return _customers;
        //    }
        //}



        //public IProductRepository Products
        //{
        //    get
        //    {
        //        if (_products == null)
        //            _products = new ProductRepository(_context);

        //        return _products;
        //    }
        //}



        //public IOrdersRepository Orders
        //{
        //    get
        //    {
        //        if (_orders == null)
        //            _orders = new OrdersRepository(_context);

        //        return _orders;
        //    }
        //}




        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
