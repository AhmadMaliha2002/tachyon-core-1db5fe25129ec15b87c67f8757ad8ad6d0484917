using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACHYON.Department.Dto;

namespace TACHYON.Department
{
    public class DepartmentService : TACHYONAppServiceBase, IDepartmentService
    {

        private readonly IRepository<department.Department> _departmentRepositry;

        public DepartmentService(IRepository<department.Department> departmentrepository)
        {

            _departmentRepositry = departmentrepository;

        }

        public async Task CreateOrUpdate(CreateOrEditDepartmentDto input)
        {
            if (input.Id != 0)
            {
                await Update(input);
                return;
            }

            await Create(input);
        }

        public async Task Delete(int Department_id)
        {
            if (Department_id == null || Department_id == 0)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your deletion has failed ");



            var task = await _departmentRepositry.SingleAsync(x => x.Id == Department_id);
            await _departmentRepositry.DeleteAsync(task);
        }


        public async Task<PagedResultDto<depatmentDto>> GetAll()
        {
            var departmentlist = _departmentRepositry.GetAll().Include(x => x.Courses).OrderBy(x => x.Id);
            ////sort
            //CoursList = !string.IsNullOrEmpty(input.Sorting) ? CoursList.OrderBy(input.Sorting) : CoursList.OrderByDescending(t => t.CreationTime);
            var totalCount = departmentlist.Count();
            //Default Paging Method
            //var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            //var taskList = CoursList.PageBy(input);
            return new PagedResultDto<depatmentDto>()
            {
                Items = ObjectMapper.Map<List<depatmentDto>>(await departmentlist.ToListAsync()),
                TotalCount = totalCount
            };
        }
        public Task<depatmentDto> GetOneDeparment(int department_id)
        {


            var department = _departmentRepositry.GetAll().Where(x => x.Id == department_id).OrderBy(x => x.CreationTime);
            return Task.FromResult(ObjectMapper.Map<depatmentDto>(department));
        }

        protected async Task Update(CreateOrEditDepartmentDto input)
        {
            if (input == null)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your creation has failed ");

            var department = await _departmentRepositry.FirstOrDefaultAsync((int)input.Id);

            ObjectMapper.Map(input, department);

            await _departmentRepositry.UpdateAsync(department);


        }
        protected async Task Create(CreateOrEditDepartmentDto input)
        {
            if (input == null)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your updating has failed ");
            var course = ObjectMapper.Map<department.Department>(input);

            await _departmentRepositry.InsertAsync(course);

        }

       
    }
}
