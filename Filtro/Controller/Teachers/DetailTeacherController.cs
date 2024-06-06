using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;
using Filtro.Services.Teachers;
using Microsoft.AspNetCore.Mvc;

namespace Filtro.Controller.Teachers
{
    public class DetailTeacherController : ControllerBase
    {
         public readonly ITeacherRepository _teacherRepository;
        public DetailTeacherController(  ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("Teacher/detail/{id}")]
        public ActionResult <Teacher> Detail(int id){
            var teacher = _teacherRepository.GetByid(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }
        
    }
}