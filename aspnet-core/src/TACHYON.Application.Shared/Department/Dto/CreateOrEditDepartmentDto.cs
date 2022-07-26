using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace TACHYON.Department.Dto
{
    public class CreateOrEditDepartmentDto: EntityDto
    {
        public string Department_Name { get; set; }
        public string Department_Description { get; set; }

    }
}
