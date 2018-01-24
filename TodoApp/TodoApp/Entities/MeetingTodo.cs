using TodoApp.Dtos;

namespace TodoApp.Entities
{
    public class MeetingTodo : Todo
    {
        public string Location { get; set; }

        public MeetingTodo() { }

        public MeetingTodo(TodoDto item) : base(item)
        {
            Location = item.Location;
        }
    }
}