﻿using DataAccessLayer.Repositories;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EFAdminDal:GenericRepository<Admin>, IAdminDal
    {

    }
}
