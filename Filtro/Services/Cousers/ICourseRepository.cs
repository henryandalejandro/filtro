using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;

namespace Filtro.Services.Cousers
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        Course? Get(int id);
        void Add(Course course);
        void Update(Course course);

    }
}