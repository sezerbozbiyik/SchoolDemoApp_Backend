using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(),"Öğrenciler Listelendi");
        }

        public IDataResult<Student> GetStudentById(int id)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(s => s.Id == id),"Öğrenci Getirildi");
        }

    }
}
