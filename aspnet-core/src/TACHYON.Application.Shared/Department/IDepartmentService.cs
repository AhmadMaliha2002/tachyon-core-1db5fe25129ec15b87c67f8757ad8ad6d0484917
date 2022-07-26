using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TACHYON.Department.Dto;

namespace TACHYON.Department
{
    public interface IDepartmentService:IApplicationService
    {

        Task<PagedResultDto<depatmentDto>> GetAll();

        Task<depatmentDto> GetOneDeparment(int department_id);
        Task CreateOrUpdate(CreateOrEditDepartmentDto input);
        Task Delete(int CourseId);




    }
}
