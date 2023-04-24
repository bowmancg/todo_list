using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_list.Repositories
{
    public class FakeDB
    {
        public List<Todo> Todos;

        public FakeDB()
        {
            Todos = new List<Todo>();
            Todos.Add(new Todo("Sort clothes to darks and lights", 1, "Laundry", false, 3));
            Todos.Add(new Todo("Take car for an oil change.", 2, "Car Maintenance", false, 6));
        }
    }
}