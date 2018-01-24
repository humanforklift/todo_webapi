using System;
using System.Collections.Generic;
using TodoApp.Dtos;

namespace TodoApp.Entities
{
    public class PartyTodo : Todo
    {
        public string[] Attendees { get; set; }
        public decimal CoverCharge { get; set; }
        public bool TakeAPlate { get; set; }
        public DateTime StartTime { get; set; }

        public PartyTodo() { }

        public PartyTodo(TodoDto item) : base(item)
        {
            //Attendees.Add(item.Attendees);
            Attendees = item.Attendees/*.Split(',')*/;
            CoverCharge = item.CoverCharge;
            TakeAPlate = item.TakeAPlate;
            StartTime = item.StartTime;
        }
    }
}