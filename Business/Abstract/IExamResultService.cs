using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamResultService
    {
        IDataResult<List<ExamResult>> GetAll();
        IDataResult<ExamResult> GetExamResultById(int id);
        IDataResult<List<ExamResultDetailDto>> GetExamResultDetails();
        IDataResult<List<ExamResultDetailDto>> GetByStudentId(int id);
        IResult Add(ExamResult examResult);
        IResult Update(ExamResult examResult);
        IResult Delete(ExamResult examResult);
    }
}
