using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Cousers;
using Microsoft.AspNetCore.Mvc;


namespace Filtro.Controller.Courses
{
    public class CreateCourseController : ControllerBase
    {
         public readonly ICourseRepository _courseRepository;
        public CreateCourseController(CourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }
        [HttpPost]
        [Route("Course/create")]
        public IActionResult Create([FromBody] Course course)
        {
            _courseRepository.Add(course);
             return Ok(new{message = "Course has been successfully created"});
             }

        }    
    }
