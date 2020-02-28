using AutoMapper;
using Lab.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using TeacherMemo.Domain;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Services.Abstract;


[ApiController]
[Route("[controller]")]
public class SubjectsController : ControllerBase
{
    private readonly ISubjectService _service;

    public SubjectsController(ISubjectService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create subject
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = Roles.Admin)]
    public IActionResult Post(string subjectName)
    {
        if (_service.GetByName(subjectName) != null)
        {
            return BadRequest(new { Message = $"Subject with name '{subjectName}' already exists." });
        }
        _service.Add(new Subject { Name = subjectName });
        return Ok();
    }


    /// <summary>
    /// Delete subject by name
    /// </summary>
    /// <returns></returns>
    [HttpDelete("{subjectName}")]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = Roles.Admin)]
    public IActionResult Delete(string subjectName)
    {
        _service.DeleteByName(subjectName);
        return Ok();
    }

    /// <summary>
    /// Get all subjects
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Get()
    {
        var result = _service.GetAll();
        if (result == null)
        {
            return NotFound();
        }
        return Ok(Mapper.Map<IEnumerable<SubjectViewModel>>(result));
    }
}