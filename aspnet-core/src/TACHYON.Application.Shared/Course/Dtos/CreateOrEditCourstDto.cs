using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace TACHYON.Course.Dtos
{
    public class CreateOrEditCourstDto:EntityDto
    {
         public string Course_Name { get; set; }
         public DateTime Course_Hours { get; set; }

         public double Price { get; set; }
         public DateTime Start_Date { get; set; }
         public DateTime End_Date { get; set; }

         public int Teacher_id { get; set; }
         public int department_id { get; set; }
    }
}
