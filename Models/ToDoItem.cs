using System;

namespace todolist_dotnet.Models
{
  public class ToDoItem
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ToDoPriority Priority { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime CompletionDate { get; set; }
  }
}