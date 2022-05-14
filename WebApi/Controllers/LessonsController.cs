using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            var results = _lessonService.GetList();
            return Ok(results);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var results = _lessonService.GetById(id);
            return Ok(results);
        }

        [HttpPost("add")]
        public IActionResult Add(Lesson lesson)
        {
            var result = _lessonService.Add(lesson);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(Lesson lesson)
        {
            _lessonService.Update(lesson);
            return Ok(lesson);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            _lessonService.Delete(id);
            return NoContent();
        }
    }
}