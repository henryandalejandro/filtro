using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    public class StudentCreateController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentCreateController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpPost]
        [Route("Student/create")]
        public IActionResult Create(Student student) {
                                            
            _studentRepository.add(student);
            return Ok(new{message = "student has been successfully created"}); }

}
}