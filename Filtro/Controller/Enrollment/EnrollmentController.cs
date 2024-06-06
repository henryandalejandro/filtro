using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;

namespace Filtro.Controller.Enrollment
{
    public class EnrollmentController
    {
        public class Enrollment
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string? Status { get; set; }

    public Student? Student { get; set; } 
    public Course? Course { get; set; }    //
}

    }
}