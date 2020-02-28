using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherMemo.Domain;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Services.Abstract;

namespace Lab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly IMemoService _memoService;

        public ReportsController(IMemoService memoService)
        {
            _memoService = memoService;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = Roles.Teacher)]
        public async Task<IActionResult> GetMyReport()
        {
            var allMemos = _memoService.GetAll();
            return GenerateReport(allMemos);
        }

        [HttpGet("all")]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = Roles.HeadDepartment)]
        public async Task<IActionResult> GetAllReport()
        {
            var allMemos = _memoService.GetAllForAllTeachers();
            return GenerateReport(allMemos);
        }

        private IActionResult GenerateReport(IEnumerable<Memo> allMemos)
        {
            var groupedMemos = allMemos.GroupBy(x => x.SubjectName);

            var lectures = groupedMemos.Select(x => new { SubjectName = x.Key, LectureHours = x.Sum(y => y.LectureHours) });
            var labs = groupedMemos.Select(x => new { SubjectName = x.Key, LabHours = x.Sum(y => y.LabHours) });
            var students = groupedMemos.Select(x => new { SubjectName = x.Key, StudentsCount = x.Sum(y => y.StudentsCount) });

            return Ok(new
            {
                lectures,
                labs,
                students
            });
        }
    }
}
