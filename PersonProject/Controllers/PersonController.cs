using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonProject.Business;
using PersonProject.DataAccess;
using PersonProject.DTOs;
using PersonProject.Entities;
using System.Collections.Generic;

namespace PersonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _personService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _personService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Person person)
        {
            var result = _personService.Add(person);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(Person person)
        {
            var result = _personService.Update(person);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Person person)
        {
            var result = _personService.Delete(person);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}



