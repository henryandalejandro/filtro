using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    public class UpdateTeacherController :  ControllerBase
    {
        public readonly  ITeacherRepository _teacherRepository;
        public UpdateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPut]
        [Route("teacher/Update/{id}")]
        public IActionResult Update ([FromBody]Teacher teacher){
            _teacherRepository.Update(teacher);
            return Ok (new{message = "Updated with success"});

        }
    }
}