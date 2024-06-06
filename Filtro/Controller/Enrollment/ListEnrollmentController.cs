using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Services.Enrollments;
using Microsoft.AspNetCore.Mvc;
using Filtro.Models;

namespace Filtro.Controller.Enrollment
{
    public class ListEnrollmentController : ControllerBase
    {
        
        public readonly IEnrollmentRepository _enrollmentRepository;
        public ListEnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        [Route("Enrollment/list")]
        public IEnumerable<Enrollment> GetEnrollment(){
            return _enrollmentRepository.GetAll();
        }
    }
}




