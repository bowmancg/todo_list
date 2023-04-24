using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace todo_list.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private readonly TodosService _todosService;

        public TodoController(TodosService todosService)
        {
            _todosService = todosService;
        }

        [HttpGet]
        public ActionResult<List<Todo>> Get()
        {
            try
            {
                List<Todo> todos = _todosService.Get();
                return Ok(todos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{todoId}")]
        public ActionResult<Todo> GetOne(int todoId)
        {
            try
            {
                Todo todo = _todosService.GetOne(todoId);
                return Ok(todo);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
    }
}