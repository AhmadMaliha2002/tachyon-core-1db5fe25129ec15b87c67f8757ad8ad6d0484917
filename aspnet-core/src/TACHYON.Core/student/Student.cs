using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TACHYON.Authorization.Users;
using TACHYON.Enums;
using TACHYON.student_course;

namespace TACHYON.student
{
    public class Student : FullAuditedEntity<long>, IMustHaveTenant
    {

     

        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }

  
        public Gender gender { get; set; }


        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
        public int TenantId { set; get; }

        public List<Student_Course> Student_Courses { get; set; }

    }
}
