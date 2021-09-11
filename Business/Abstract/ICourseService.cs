using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetCourseById(int id);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
    }
}
