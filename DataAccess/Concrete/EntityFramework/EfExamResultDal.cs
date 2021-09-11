using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExamResultDal : EfEntityRepositoryBase<ExamResult, SchoolContext>, IExamResultDal
    {

        //public List<ExamResultDetailDto> GetExamResultDetails()
        //{
        //    using (SchoolContext context = new SchoolContext())
        //    {
        //        var result = from e in context.Students
        //                     join s in context.ExamResults
        //                     on s.Id equals e.StudentId
        //                     select new ExamResultDetailDto
        //                     {
        //                         ExamId = e.Id,
        //                         Score=e.Score,
        //                         StudentName=s.FullName
        //                     };
        //        return result.ToList();
        //    }
        //}
        public List<ExamResultDetailDto> GetExamResultDetails()
        {
            throw new NotImplementedException();
        }
    }
}
