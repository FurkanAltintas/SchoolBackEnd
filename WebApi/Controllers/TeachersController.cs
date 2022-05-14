using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            var lessons = _teacherService.GetList();
            return Ok(lessons);
        }

        [HttpPost("add")]
        public IActionResult Add(TeacherRegisterDto teacherRegisterDto)
        {
            _teacherService.Add(teacherRegisterDto);
            return Ok(teacherRegisterDto);
        }
    }
}
