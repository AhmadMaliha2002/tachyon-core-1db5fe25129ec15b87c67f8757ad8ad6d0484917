using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using TACHYON.Enums;

namespace TACHYON.student_course.DTO
{
    public class StudentCoursDto: EntityDto
    {
        public StudentStatus studentStatus { get; set; }
        public double Total_Payment { get; set; }
        public double Grade { get; set; }

        public long? student_id { get; set; }
    

        public int? cours_id { get; set; }
      

    }
}
