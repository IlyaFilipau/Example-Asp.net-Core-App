﻿using Asp.net_Core_WebApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Core_WebApplication.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
