using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExamResultManager : IExamResultService
    {
        IExamResultDal _examResultDal;

        public ExamResultManager(IExamResultDal examResultDal)
        {
            _examResultDal = examResultDal;
        }

        public IDataResult<List<ExamResult>> GetAll()
        {
            return new SuccessDataResult<List<ExamResult>>(_examResultDal.GetAll(),"Sınavlar Listelendi");
        }

        public IDataResult<ExamResult> GetExamResultById(int id)
        {
            return new SuccessDataResult<ExamResult>(_examResultDal.Get(e => e.Id == id),"Sınav Listelendi");
        }
    }
}
