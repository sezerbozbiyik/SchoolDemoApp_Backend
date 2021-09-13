using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(ExamResult examResult)
        {
            _examResultDal.Add(examResult);
            return new SuccessResult("Yeni Kurs Eklendi");
        }

        public IResult Delete(ExamResult examResult)
        {
            _examResultDal.Delete(examResult);
            return new SuccessResult("Kurs Silindi");
        }

        public IDataResult<List<ExamResult>> GetAll()
        {
            return new SuccessDataResult<List<ExamResult>>(_examResultDal.GetAll(),"Sınavlar Listelendi");
        }

        public IDataResult<List<ExamResultDetailDto>> GetByStudentId(int id)
        {
            return new SuccessDataResult<List<ExamResultDetailDto>>(_examResultDal.GetByStudentId(id));
        }

        public IDataResult<ExamResult> GetExamResultById(int id)
        {
            return new SuccessDataResult<ExamResult>(_examResultDal.Get(e => e.Id == id),"Sınav Listelendi");
        }

        public IDataResult<List<ExamResultDetailDto>> GetExamResultDetails()
        {
            return new SuccessDataResult<List<ExamResultDetailDto>>(_examResultDal.GetExamResultDetails(),"ExamResult DTO listelendi");
        }

        public IResult Update(ExamResult examResult)
        {
            _examResultDal.Update(examResult);
            return new SuccessResult("Kurs Güncellendi");
        }
    }
}
