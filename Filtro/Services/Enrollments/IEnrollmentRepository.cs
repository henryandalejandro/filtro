using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filtro.Models;

namespace Filtro.Services.Enrollments
{
    public interface IEnrollmentRepository
    {
        IEnumerable<Enrollment> GetAll();
    //    IEnumerable<Enrollment> GetPending();
    //    IEnumerable<Enrollment> GetPaid();
    //  IEnumerable<Enrollment> GetPayment();
    //  IEnumerable<Enrollment> GetCancelled ();

     Enrollment? GetById(int id);
        void Add (Enrollment enrollment);
        // void Update(Enrollment enrollment);
         void Cancelled (int id);

        //  void Getpad(int id);

    }
}