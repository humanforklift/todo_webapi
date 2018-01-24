using TodoApp.Entities;
using TodoApp.Enums;
using System;
using System.Collections.Generic;

namespace TodoApp.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TodoType Type { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset DueDate { get; set; }

        // Meeting Properties
        public string Location { get; set; }

        //Party Properties
        public string[] Attendees { get; set; }
        public decimal CoverCharge { get; set; }
        public bool TakeAPlate { get; set; }
        public DateTime StartTime { get; set; }

        public TodoDto()
        {
        }

        public TodoDto(Todo item)
        {
            Type = item.Type;
            Title = item.Title;
            Id = item.Id;
            Description = item.Description;

            if (item is MeetingTodo)
            {
                Location = ((MeetingTodo)item).Location;
            }

            if (item is PartyTodo)
            {
                //Attendees = ((PartyTodo)item).Attendees;/*new List<string> {}*/;
                Attendees.SetValue(((PartyTodo)item).Attendees, 0);
                CoverCharge = ((PartyTodo)item).CoverCharge;
                TakeAPlate = ((PartyTodo)item).TakeAPlate;
                StartTime = ((PartyTodo)item).StartTime;
            }
        }
    }
}