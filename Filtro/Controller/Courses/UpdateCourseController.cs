using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Cousers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Courses
{
    public class UpdateCourseController :ControllerBase 
    {
        public  readonly  ICourseRepository _courseRepository;
        public UpdateCourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        [HttpPost]
        [Route("Course/update")]
        public IActionResult UpdateCourse([FromBody] Course course)
        {
            _courseRepository.Update(course);
            return Ok (new{message = " course Updated with success"});
    }
}
}