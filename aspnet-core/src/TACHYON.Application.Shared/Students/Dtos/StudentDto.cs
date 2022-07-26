using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using TACHYON.Authorization.Users.Dto;
using TACHYON.Enums;
using TACHYON.student_course.DTO;

namespace TACHYON.Students.Dtos
{
    public class StudentDto:EntityDto
    {

        public UserListDto User { get; set; }

        public DateTime DateofBirth { get; set; }

        public Gender gender { get; set; }



        public int TenantId { set; get; }

        public List<StudentCoursDto> Student_Courses { get; set; }

    }
}
