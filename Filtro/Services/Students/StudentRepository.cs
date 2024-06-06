using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.Models;

namespace Filtro.Services.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SistemaSgContext _context;
        public StudentRepository(SistemaSgContext context)
        {
            _context = context;
        }

        
        public void add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student? Get(int id)
        {
            return _context.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Update(Student student)
        {
            var existingStudent = _context.Students.Find(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Names = student.Names;
                existingStudent.BirthDate = student.BirthDate;
                existingStudent.Address = student.Address;
                existingStudent.Email = student.Email;
                 _context.Students.Update(existingStudent);
                _context.SaveChanges();

            }

        }
    }
}