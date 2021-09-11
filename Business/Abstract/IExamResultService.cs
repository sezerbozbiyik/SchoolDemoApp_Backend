using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamResultService
    {
        IDataResult<List<ExamResult>> GetAll();
        IDataResult<ExamResult> GetExamResultById(int id);
    }
}
