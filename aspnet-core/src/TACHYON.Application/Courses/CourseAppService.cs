using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACHYON.Course;
using TACHYON.Course.Dtos;

namespace TACHYON.Courses
{
    public class CourseAppService : TACHYONAppServiceBase, ICourseAppService
    {

        private readonly IRepository<Cours> _courseRepositry;

        public CourseAppService(IRepository<Cours> courserepository) { 
        
            _courseRepositry = courserepository;

        }


        public async Task CreateOrUpdate(CreateOrEditCourstDto input)
        {
            if (input.Id != 0)
            {
                await Update(input);
                return;
            }

            await Create(input);
        }

        public async Task Delete(int CourseId)
        {
            if (CourseId == null || CourseId == 0)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your deletion has failed ");



            var task = await _courseRepositry.SingleAsync(x => x.Id == CourseId);
            await _courseRepositry.DeleteAsync(task);
        }

        public async Task<PagedResultDto<CourseDto>> GetAllByDepartmentID(int Department_Id)
        {
            var CoursList = _courseRepositry.GetAll().Where(x => x.department_id == Department_Id).OrderBy(x => x.CreationTime);
            ////sort
            //CoursList = !string.IsNullOrEmpty(input.Sorting) ? CoursList.OrderBy(input.Sorting) : CoursList.OrderByDescending(t => t.CreationTime);
            var totalCount = CoursList.Count();
            //Default Paging Method
            //var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            //var taskList = CoursList.PageBy(input);
            return new PagedResultDto<CourseDto>()
            {
                Items = ObjectMapper.Map<List<CourseDto>>(await CoursList.ToListAsync()),
                TotalCount = totalCount
            };
        }

        public async Task<PagedResultDto<CourseDto>> GetAllByTeacherID(int Teacher_Id)
        {

            var CoursList = _courseRepositry.GetAll().Where(x => x.Teacher_id == Teacher_Id).OrderBy(x => x.CreationTime);
            ////sort
            //CoursList = !string.IsNullOrEmpty(input.Sorting) ? CoursList.OrderBy(input.Sorting) : CoursList.OrderByDescending(t => t.CreationTime);
            var totalCount = CoursList.Count();
            //Default Paging Method
            //var taskList = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            //var taskList = CoursList.PageBy(input);
            return new PagedResultDto<CourseDto>()
            {
                Items = ObjectMapper.Map<List<CourseDto>>(await CoursList.ToListAsync()),
                TotalCount = totalCount
            };
        }



        protected async Task Update(CreateOrEditCourstDto input)
        {
            if (input == null)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your creation has failed ");

            var course = await _courseRepositry.FirstOrDefaultAsync((int)input.Id);

            ObjectMapper.Map(input, course);

            await _courseRepositry.UpdateAsync(course);


        }
        protected async Task Create(CreateOrEditCourstDto input)
        {
            if (input == null)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your updating has failed ");
            var course = ObjectMapper.Map<Cours>(input);

            await _courseRepositry.InsertAsync(course);

        }
    }
}
