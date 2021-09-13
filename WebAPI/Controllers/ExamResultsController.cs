using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamResultsController : ControllerBase
    {
        IExamResultService _examResultService;

        public ExamResultsController(IExamResultService examResultService)
        {
            _examResultService = examResultService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _examResultService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbydto")]
        public IActionResult GetAllDto()
        {
            var result = _examResultService.GetExamResultDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _examResultService.GetExamResultById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbystudentid")]
        public IActionResult GetByStudentId(int id)
        {
            var result = _examResultService.GetByStudentId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ExamResult examResult)
        {
            var result = _examResultService.Add(examResult);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ExamResult examResult)
        {
            var result = _examResultService.Delete(examResult);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ExamResult examResult)
        {
            var result = _examResultService.Update(examResult);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
