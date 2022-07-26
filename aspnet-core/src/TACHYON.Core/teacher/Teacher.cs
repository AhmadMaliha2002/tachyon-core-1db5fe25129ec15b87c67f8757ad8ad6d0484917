using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TACHYON.Authorization.Users;
using TACHYON.Course;
using TACHYON.Enums;

namespace TACHYON.teacher
{
    public class Teacher : FullAuditedEntity
    {

        public string Teacher_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [DataType(DataType.Date)]
        public string DateofEmployment { get; set; }
        public Gender gender { get; set; }
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }

        public List<Cours> Courses { get; set; }

    }
}
