﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;

namespace NAA.Services.IService
{
    public interface IUniversityService
    {
        IList<University> GetUniversities();
    }
}
