using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Services.Cousers
{
    public class CourseRepository : ICourseRepository
    {
         private readonly SistemaSgContext _context;
        public CourseRepository(SistemaSgContext context){
            _context = context;
        }
//crear
        public void Add(Course course)
        {
            
          _context.Courses.Add(course);
            _context.SaveChanges(); 
        }

        public Course? Get(int id)
        {
            throw new NotImplementedException();
        }

        //listar todo
        public IEnumerable<Course> GetAll()
        {
        return _context.Courses
        .Include (s=>s.TeacherId)
        .ToList();
        }
//detalle
        public Course? GetById(int id)
        {
            return _context.Courses.Find(id);
        }
//Actualizar
        public void Update(Course course)
        {
    {  var existingCourse = _context.Courses .Find(course.Id);  
    
     if (existingCourse != null)
  { 
existingCourse.Name = course.Name;
existingCourse.Description = course.Description;
  existingCourse.TeacherId = course.TeacherId;
 existingCourse.Schedule = course.Schedule;
existingCourse.Duration = course.Duration;
existingCourse.Capacity = course.Capacity;

                _context.Courses.Update(existingCourse);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("course not found");
            }

        }
    }}}