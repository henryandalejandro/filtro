using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Data;
using Filtro.Models;
using Microsoft.EntityFrameworkCore;

namespace Filtro.Services.Enrollments
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly SistemaSgContext _context;
        public EnrollmentRepository(SistemaSgContext context)
        {
            _context = context;
        }




        public void Add(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public void Cancelled(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment != null)
            {
                enrollment.Status = "Cancelled";
                _context.Enrollments.Attach(enrollment);
                _context.Entry(enrollment).Property(b => b.Status).IsModified = true;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Enrollment> GetAll()
        {
            var Enrollment = _context.Enrollments
                          .Where(s => s.Status == "Cancelled")
                          .Include(c => c.StudentId)
                          .Include(c => c.CourseId)
                          .ToList();
            return Enrollment;
        }

        Enrollment? IEnrollmentRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    // public Enrollment? GetById(int id)
    // {
    //     return _context.Enrollments

    //                   .Include(c => c.StudentId)
    //                   .Include(c => c.CourseId)
    //                   .FirstOrDefault(c => c.Id == id);
    // }

    // public IEnumerable<Enrollment> GetCancelled()
    // {
    //   return _context.Citas
    //                        .Where(s => s.Estado == "Cancelada")
    //                        .Include(c => c.Medico)
    //                        .Include(c => c.Paciente)
    //                     //    .Include(c => c.Tratamientos)
    //                        .ToList();
    // }

    // public void Getpad(int id)
    // {
    //     throw new NotImplementedException();
    // }

    // public IEnumerable<Enrollment> GetPaid()
    // {
    //     throw new NotImplementedException();
    // }

    // public IEnumerable<Enrollment> GetPayment()
    // {
    //     throw new NotImplementedException();
    // }

    // public IEnumerable<Enrollment> GetPending()
    // {
    //     throw new NotImplementedException();
    // }

    // public void Update(Enrollment enrollment)
    // {
    //     throw new NotImplementedException();
    // }
}
