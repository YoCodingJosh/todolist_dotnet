using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolist_dotnet
{
    public class ToDoItem
    {
        public enum ToDoStatus
        {
            ToDo,
            InProgress,
            Completed,
        }

        public int Id { get; set; }
        public ToDoStatus Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Important { get; set; }
    }
}
