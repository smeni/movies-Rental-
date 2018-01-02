using _3.DAL;
using _4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BL
{
    public class OrderManager
    {
        private Movies_Rental_DBEntities ctx;

        public OrderManager()
        {
            ctx = new Movies_Rental_DBEntities();
        }

        public List<Orders> Orders
        {
            get
            {
                return ctx.Orders.Where(o => o.IsActiv == true).ToList();
            }
        }

        public Orders GetById(int orderId)
        {
            return ctx.Orders.Where(o => o.OrderID == orderId).FirstOrDefault();
        }

        public bool Insert(Orders neworder)
        {
            ctx = new Movies_Rental_DBEntities();
           
                ctx.Orders.Add(neworder);

                int count = ctx.SaveChanges();
                return count > 0;
            
        }
    }
}
