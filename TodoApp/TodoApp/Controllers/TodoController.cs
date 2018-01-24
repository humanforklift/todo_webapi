using System.Collections.Generic;
using System.Web.Http;
using TodoApp.Dtos;
using TodoApp.Entities;
using TodoApp.Enums;

namespace TodoApp.Controllers
{
    public class TodoController : ApiController
    {
        public IHttpActionResult Get()
        {
            var entities = TodoRepository.Get();
            var todos = new List<TodoDto>();
            foreach (var entity in entities)
            {
                todos.Add(new TodoDto(entity));
            }

            return Ok(todos);
        }

        // Get todo by id
        public IHttpActionResult GetById(int id)
        {
            var item = TodoRepository.Get(id);
            if (item == null)
            {
                // returns 404 code
                return NotFound();
            }
            return Ok(new TodoDto(item));
        }

        // Remove Todo item
        public IHttpActionResult Remove(int id)
        {
            var item = TodoRepository.Remove(id);

            if (item == null)
            {
                return BadRequest();
            }

            return Ok(TodoRepository.Get());
        }

        // Add Todo Item
        public IHttpActionResult Add(TodoDto item)
        {
            Todo entity;

            switch(item.Type)
            {
                case TodoType.Party:
                    entity = new PartyTodo(item);
                    break;
                case TodoType.Meeting:
                    entity = new MeetingTodo(item);
                    break;
                default:
                case TodoType.General:
                    entity = new Todo(item);
                    break;
            }
            
            return Ok(TodoRepository.Add(entity));
        }
    }
}
