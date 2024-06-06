using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;

namespace Filtro.Services.Students
{
    public interface IStudentRepository
    {
        IEnumerable<Student>GetAll();
        Student Get(int id);

        void add (Student student);
        void Update(Student student);
        
        
    }
}