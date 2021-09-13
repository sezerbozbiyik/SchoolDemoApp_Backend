using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExamResultDal : EfEntityRepositoryBase<ExamResult, SchoolContext>, IExamResultDal
    {
        public List<ExamResultDetailDto> GetByStudentId(int id)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var result = from e in context.ExamResults
                             where e.StudentId == id
                             join s in context.Students
                             on e.StudentId equals s.Id
                             join c in context.Courses
                             on e.CourseId equals c.Id
                             select new ExamResultDetailDto
                             {
                                 ExamId = e.Id,
                                 Score = e.Score,
                                 StudentName = s.FullName,
                                 CourseName = c.Name
                             };
                return result.ToList();
            }
        }

        public List<ExamResultDetailDto> GetExamResultDetails()
        {
            using (SchoolContext context = new SchoolContext())
            {
                var result = from e in context.ExamResults
                             join s in context.Students
                             on e.StudentId equals s.Id
                             join c in context.Courses
                             on e.CourseId equals c.Id
                             select new ExamResultDetailDto
                             {
                                 ExamId = e.Id,
                                 Score = e.Score,
                                 StudentName = s.FullName,
                                 CourseName=c.Name
                             };
                return result.ToList();
            }
        }
    }
}
