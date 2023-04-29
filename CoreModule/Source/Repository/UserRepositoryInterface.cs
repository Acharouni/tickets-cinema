﻿using CoreModule.Base;
using CoreModule.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModule.Source.Repository
{
    public interface UserRepositoryInterface:BaseRepositoryInterface<ApplicationUser>
    {
        Task<ApplicationUser?> GetByIdString(string id);
    }
}
