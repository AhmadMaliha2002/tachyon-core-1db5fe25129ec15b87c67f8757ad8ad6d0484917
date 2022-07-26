using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TACHYON.student_course.DTO;

namespace TACHYON.student_course
{
    public interface IStudentCouseServiecs :IApplicationService
    {


        Task<PagedResultDto<StudentCoursDto>> GetAllByStudentID(int Student_ID);

        Task CreateOrUpdate(CreateOrEditStudentCours input);
        Task Delete(int SCId);


    }
}
