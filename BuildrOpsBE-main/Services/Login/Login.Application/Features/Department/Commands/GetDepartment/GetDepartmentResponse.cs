﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildrOps.Application.Features.Department.Commands.GetDepartment
{
    public class GetDepartmentResponse
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDetails { get; set; }
    }
}