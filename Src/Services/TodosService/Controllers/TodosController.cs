using Microsoft.AspNetCore.Mvc;

namespace TodosService.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            var todo = new Todo
            {
                Title = "TestTitle"
            };

            return new List<Todo> { todo };
        }
    }
}
