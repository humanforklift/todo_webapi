using System;
using TodoApp.Dtos;
using TodoApp.Enums;

namespace TodoApp.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TodoType Type { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset DueDate { get; set; }

        public Todo() { }

        public Todo(TodoDto item)
        {
            Type = item.Type;
            Title = item.Title;
            Description = item.Description;
            CreatedDate = DateTime.Now;
            CreatedBy = "Postman";
            DueDate = item.DueDate;
        }
    }
}