using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro.Models
{
    
    public class Teacher
    {
         public int Id { get; set; }
    public string? Names { get; set; }
    public string? Specialty { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public int YearsExperience { get; set; }
    
    }
}