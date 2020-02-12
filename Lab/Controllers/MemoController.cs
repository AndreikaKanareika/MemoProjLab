using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lab.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeacherMemo.Domain;
using TeacherMemo.Services.Abstract;

namespace Lab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemoController : ControllerBase
    {
        private readonly IMemoService _memoService;
        public MemoController(IMemoService memoService)
        {
            _memoService = memoService;
        }

        /// <summary>
        /// Create memo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(CreateMemoViewModel model)
        {
            var item = Mapper.Map<Memo>(model);
            var result = _memoService.Add(item);
            return Ok(Mapper.Map<MemoViewModel>(result));
        }

        /// <summary>
        /// Update memo
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(UpdateMemoViewModel model)
        {
            var item = Mapper.Map<Memo>(model);
            var result = _memoService.Update(item);
            return Ok(Mapper.Map<MemoViewModel>(result));
        }

        /// <summary>
        /// Delete memo by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _memoService.Delete(id);
            return Ok();
        }

        /// <summary>
        /// Get memo by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _memoService.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<MemoViewModel>(result));
        }

        /// <summary>
        /// Get all memos
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var result = _memoService.GetAll();
            return Ok(Mapper.Map<IEnumerable<MemoViewModel>>(result));
        }

        /// <summary>
        /// Find memos in the range of lecture hours
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpGet("find/lecturesHours")]
        public IActionResult FindB(int from, int to)
        {
            var result = _memoService.FindInRangeByLecturesHours(from, to);
            return Ok(Mapper.Map<IEnumerable<MemoViewModel>>(result));
        }
    }
}
