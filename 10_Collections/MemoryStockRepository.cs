﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{

    interface IStockRepository
    {
        long NextId();
    }

    class MemoryStockRepository : IStockRepository
    {

        public long NextId()
        {

        }

    }
}
