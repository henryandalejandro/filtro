using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;

namespace Filtro.Services.Teachers
{
    public interface ITeacherRepository
    {
         IEnumerable<Teacher>GetAll();
        Teacher GetByid(int id);

        void Add (Teacher teacher);
        void Update(Teacher teacher);
    }
}