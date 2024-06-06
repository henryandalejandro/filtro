using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Students
{
    public class StudentController: ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpGet]
        [Route("Student/list")]
        public IEnumerable<Student> GetStudent(){
            return _studentRepository.GetAll();
        }










    }
}