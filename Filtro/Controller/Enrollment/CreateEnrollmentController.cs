using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Services.Enrollments;
using Microsoft.AspNetCore.Mvc;
using Filtro.Models;


namespace Filtro.Controller.Enrollment
{
    public class CreateEnrollmentController : ControllerBase
     {
    //     private readonly IEnrollmentRepository _enrollmentRepository;
    //     public CreateEnrollmentController(IEnrollmentRepository enrollmentRepository)
    //     {
    //         _enrollmentRepository = enrollmentRepository;
    //     }
    //     [HttpPost]
    //     [Route("Enrollment/Create")]
    //     public IActionResult Create([FromBody] Enrollment enrollment)
    //     {
    //         if(enrollment == null)
    //         {
    //             return BadRequest("null enrollment");
    //         }
    //         _enrollmentRepository.Add(enrollment);
    //         return Ok(new{message = "Enrollment  whith exito"});

    // }
}
}
