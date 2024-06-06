using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    public class CreateTeacherController : ControllerBase
    {

 private readonly ITeacherRepository _teacherRepository;
        public CreateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        [HttpPost]
        [Route("Teacher/Create")]
        public IActionResult Create([FromBody] Teacher teacher)
        {
            _teacherRepository.Add(teacher);
         return Ok(new{message = "Teacher has been successfully created"}); }

        }    
}
