using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    public class StudentUpdateController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;
        public StudentUpdateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpPut]
        [Route("Student/Update/{id}")]
        public IActionResult Update ([FromBody]Student student){
            _studentRepository.Update(student);
            return Ok (new{message = "Updated with success"});


        }
    }
}