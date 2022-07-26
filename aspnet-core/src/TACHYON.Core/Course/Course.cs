using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TACHYON.department;
using TACHYON.student_course;
using TACHYON.teacher;

namespace TACHYON.Course
{
    public class Cours : FullAuditedEntity
    {

        public string Course_Name { get; set; }

        [DataType(DataType.Time)]
        public DateTime Course_Hours { get; set; }


        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start_Date { get; set; }
        [DataType(DataType.Date)]
        public DateTime End_Date { get; set; }


        public int Teacher_id { get; set; }
        [ForeignKey("Teacher_id")]
        public Teacher teacher { get; set; }

        public int department_id { get; set; }
        [ForeignKey("department_id")]
        public Department department { get; set; }

        public List<Student_Course> Student_Courses { get; set; }
    }
}
