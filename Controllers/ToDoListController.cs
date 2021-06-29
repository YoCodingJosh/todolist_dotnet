using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using todolist_dotnet.Models;

namespace todolist_dotnet.Controllers
{
  // [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class ToDoListController : ControllerBase
  {
    private readonly ILogger<ToDoListController> _logger;

    public ToDoListController(ILogger<ToDoListController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IEnumerable<ToDoItem> Get()
    {
      return new List<ToDoItem>()
      {
        new ToDoItem()
        {
          Id = 1,
          Title = "Finish this app",
          Description = "You always leave apps unfinished, finish this one.",
          Priority = ToDoPriority.High
        }
      };
    }
  }
}
