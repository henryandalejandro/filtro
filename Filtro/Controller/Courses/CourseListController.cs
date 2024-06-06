using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Cousers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Courses
{
    public class CourseListController : ControllerBase
    {
                public readonly ICourseRepository _courseRepository;
        public CourseListController(CourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }

        [HttpGet]
        [Route("Course/list")]
        public IEnumerable<Course> GetCourse(){
            return _courseRepository.GetAll();
        }

    }
}