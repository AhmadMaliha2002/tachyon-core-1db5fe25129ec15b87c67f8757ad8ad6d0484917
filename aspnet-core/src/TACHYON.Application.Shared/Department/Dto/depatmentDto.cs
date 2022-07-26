using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using TACHYON.Course.Dtos;

namespace TACHYON.Department.Dto
{
    public class depatmentDto: EntityDto
    {


        public string Department_Name { get; set; }
        public string Department_Description { get; set; }
        public List<CourseDto> Courses { get; set; }
    }
}
