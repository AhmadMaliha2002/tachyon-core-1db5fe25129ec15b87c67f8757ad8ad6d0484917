using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TACHYON.Course;
using TACHYON.Enums;
using TACHYON.student;

namespace TACHYON.student_course
{
    public class Student_Course : FullAuditedEntity
    {


        public StudentStatus studentStatus { get; set; }
        public double Total_Payment { get; set; }
        public double Grade { get; set; }

        public long? student_id { get; set; }
        [ForeignKey("student_id")]
        public Student student { get; set; }

        public int? cours_id { get; set; }
        [ForeignKey("cours_id")]
        public Cours cours { get; set; }
    }
}
