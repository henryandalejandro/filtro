using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    public class TeacherListController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;
        public TeacherListController(  ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("Teacher/list")]

        public IEnumerable<Teacher> GetTeacher(){
            return _teacherRepository.GetAll();
        }




    }
}