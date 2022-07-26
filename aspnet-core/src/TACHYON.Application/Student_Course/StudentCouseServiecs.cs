using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACHYON.student_course;
using TACHYON.student_course.DTO;

namespace TACHYON.Student_Course
{
    public class StudentCouseServiecs : TACHYONAppServiceBase, IStudentCouseServiecs
    {

        private readonly IRepository<student_course.Student_Course> _StudentCourserepository;
        public StudentCouseServiecs(IRepository<student_course.Student_Course> repository) {


            _StudentCourserepository = repository;


        }
        public Task CreateOrUpdate(CreateOrEditStudentCours input)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int SCId)
        {
            if (SCId == null || SCId== 0)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your deletion has failed ");



            var task = await _StudentCourserepository.SingleAsync(x => x.Id == SCId);
            await _StudentCourserepository.DeleteAsync(task);
        }

        public async Task<PagedResultDto<StudentCoursDto>> GetAllByStudentID(int Student_ID)
        {
            if (Student_ID==null)
            {
                throw new UserFriendlyException("Ooppps! There is a problem!, Your updating has failed");
            }
            var StudentsList = await _StudentCourserepository.GetAll().Where(x=>x.student_id==Student_ID).ToListAsync();

            var totalCount = StudentsList.Count();

            return new PagedResultDto<StudentCoursDto>()
            {
                Items = ObjectMapper.Map<List<StudentCoursDto>>(StudentsList),
                TotalCount = totalCount
            };

        }


        protected async Task Create(CreateOrEditStudentCours input){


            if (input is null)
                throw new UserFriendlyException("Ooppps! There is a problem!", "Your updating has failed ");

       
            var studentCourse = ObjectMapper.Map<student_course.Student_Course>(input);


            await _StudentCourserepository.InsertAsync(studentCourse);
        
        }



    }
}
