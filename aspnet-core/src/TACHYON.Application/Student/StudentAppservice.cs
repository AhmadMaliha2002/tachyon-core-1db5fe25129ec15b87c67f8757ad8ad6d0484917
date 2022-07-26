using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TACHYON.student_course.DTO;
using TACHYON.Students;

namespace TACHYON.Student
{
    public class StudentAppservice : TACHYONAppServiceBase, IStudentAppservice
    {


        //private readonly IRepository<student.Student> _Studentepository;
        //public StudentAppservice(IRepository<student.Student> repository)
        //{


        //    _Studentepository = repository;


        //}
      
        public Task CreateOrEditStudentCourse(CreateOrEditStudentCours input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int SCID)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<StudentCoursDto>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
