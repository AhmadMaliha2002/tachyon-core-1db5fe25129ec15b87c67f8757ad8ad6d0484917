using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TACHYON.Course.Dtos;

namespace TACHYON.Course
{
    public interface ICourseAppService : IApplicationService
    {

        Task<PagedResultDto<CourseDto>> GetAllByTeacherID(int Teacher_Id);
        Task<PagedResultDto<CourseDto>> GetAllByDepartmentID(int Department_Id);
        Task CreateOrUpdate(CreateOrEditCourstDto input);
        Task Delete(int CourseId);



    }
}
