using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult("Yeni Kurs Eklendi");
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult("Seçilen Kurs Silindi");
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),"Kurslar Listelendi");
        }

        public IDataResult<Course> GetCourseById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c => c.Id == id),"Kurs Getirildi");
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult("Seçilen Kurs Güncellendi");
        }
    }
}
