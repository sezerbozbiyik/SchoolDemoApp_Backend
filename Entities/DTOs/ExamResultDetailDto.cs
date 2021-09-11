using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamResultDetailDto:IDto
    {
        public int ExamId { get; set; }
        public string StudentName { get; set; }
        public int Score { get; set; }
    }
}
