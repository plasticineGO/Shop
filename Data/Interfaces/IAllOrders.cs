using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_1.Data.Models;

namespace WebApplication_1.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}

