using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.Models;

namespace Filtro.Services.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
          private readonly SistemaSgContext _context;
        public TeacherRepository(SistemaSgContext context)
        {
            _context = context;
        }


        public void Add(Teacher teacher)
        {
                _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public IEnumerable<Teacher> GetAll()
        {
        return _context.Teachers.ToList();

        }

        public Teacher? GetByid(int id)
        {
         return _context.Teachers.Find(id);

        }

        public void Update(Teacher teacher)
        {
          var existingTeacher = _context.Teachers.Find(teacher.Id);
           if (existingTeacher != null)
           {
            existingTeacher.Names = teacher.Names;
            existingTeacher.Specialty = teacher.Specialty;
            existingTeacher.Phone = teacher.Phone;
            existingTeacher.Email = teacher.Email;
            existingTeacher.YearsExperience = teacher.YearsExperience;

            _context.Teachers.Update(existingTeacher);

            _context.SaveChanges();
           }

        }

        
    }
}