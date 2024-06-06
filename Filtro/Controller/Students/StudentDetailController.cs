using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    public class StudentDetailController : ControllerBase
    {
         private readonly IStudentRepository _studentRepository;
        public StudentDetailController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("Student/Detail/{id}")]
        public ActionResult<Student>Detail (int id){
            var student = _studentRepository.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student); 
        }


    }
}