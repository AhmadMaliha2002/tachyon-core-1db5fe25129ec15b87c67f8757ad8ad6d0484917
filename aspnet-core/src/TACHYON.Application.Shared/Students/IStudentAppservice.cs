using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TACHYON.student_course.DTO;

namespace TACHYON.Students
{
    public interface IStudentAppservice: IApplicationService
    {
        Task CreateOrEditStudentCourse(CreateOrEditStudentCours input );

        Task<PagedResultDto<StudentCoursDto>> GetAll();

        Task Delete(int SCID);
    }
}
