using System.Collections.Generic;
using System.Linq;
using TodoApp.Entities;

namespace TodoApp
{
	public static class TodoRepository
	{
		private static int _id = 1;
		private static List<Todo> _todos;

		public static void Init( )
		{
			_todos = new List<Todo>( );
			Seed( );
		}

		public static List<Todo> Get( )
		{
			return _todos;
		}

		public static Todo Get( int id )
		{
			return _todos.FirstOrDefault( todo => todo.Id == id );
		}

		public static Todo Add(Todo todo )
		{
			todo.Id = _id++;
			_todos.Add(todo);
			return todo;
		}

        /*public static Todo AddMeeting(Todo todo)
        {
            todo.Id = _id++;
            _todos.Add(todo);
            return todo;
        }*/

		public static Todo Remove( int id )
		{
			var todo = Get( id );
			_todos.Remove( todo );
			return todo;
		}
		
		private static void Seed( )
		{
			Add( new Todo { Title = "Todo 1", Type = Enums.TodoType.General } );
			Add( new MeetingTodo { Title = "Todo 2", Location = "My house" } );
			Add( new MeetingTodo { Title = "Todo 3" } );
            Add( new MeetingTodo { Title = "Meeting", Location = "The Mount", Type = Enums.TodoType.Meeting });
		}
	}
}