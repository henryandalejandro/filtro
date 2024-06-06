using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Cousers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Courses
{
    public class DetailCourseController : ControllerBase
    {
        public readonly ICourseRepository _courseRepository;
        public DetailCourseController(CourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }
        
        [HttpGet]
        [Route("Course/Details/{id}")]
        public ActionResult <Course> Detail(int id){
            var course = _courseRepository.GetType();
            if(course == null){
                return NotFound();
            }
            return Ok(course);

        }

       
    }
}