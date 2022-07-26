using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using TACHYON.Authorization.Users.Dto;
using TACHYON.Enums;
using TACHYON.student_course.DTO;

namespace TACHYON.Students.Dtos
{
    public class CreateOrEditStudent: EntityDto
    {

        public CreateOrUpdateUserInput userInfo  { get; set; }

        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }

         public Gender gender { get; set; }


      
        public int TenantId { set; get; }

      

    }
}
