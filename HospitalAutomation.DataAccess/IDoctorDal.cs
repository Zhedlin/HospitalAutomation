﻿using HospitalAutomation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.DataAccess
{
    public interface IDoctorDal : IEntityRepository<Doctor>
    {
        List<Doctor> GetByPolyclinicId(int id);
    }
}
