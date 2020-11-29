using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todo_api_net.Models;

namespace todo_api_net.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TaskController : ControllerBase
  {
    private DataContext Db { get; set; }

    public TaskController(DataContext dataContext)
    {
      Db = dataContext;
    }

    [HttpGet]
    public IEnumerable<Task> GetAll()
    {
      var tasks = Db.Task.ToList();
      return tasks;
    }

    [HttpPost]
    public string Add([FromBody] TaskRequest newTask)
    {
      var task = new Task {Description = newTask.Description};
      Db.Task.Add(task);
      Db.SaveChanges();
      return "Task saved";
    }
  }
}