namespace todolist_dotnet.Models
{
  public enum ToDoPriority
  {
    Low,
    Normal,
    High
  }

  public class ToDoItem
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ToDoPriority Priority { get; set; }
  }
}