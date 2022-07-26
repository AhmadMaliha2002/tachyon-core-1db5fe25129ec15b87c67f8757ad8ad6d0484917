using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using TACHYON.Course;

namespace TACHYON.department
{
    public class Department : FullAuditedEntity
    {

        public string Department_Name { get; set; }
        public string Department_Description { get; set; }
        public List<Cours> Courses { get; set; }

    }
}
