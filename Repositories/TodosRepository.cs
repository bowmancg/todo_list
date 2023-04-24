using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_list.Repositories
{
    public class TodosRepository
    {
        private readonly FakeDB _db;

        public TodosRepository(FakeDB db)
        {
            _db = db;
        }

        internal Todo Create(Todo todoData)
        {
            int todoId = _db.Todos[_db.Todos.Count - 1].Id + 1;
            Todo newTodo = new Todo(todoData.Body, todoId, todoData.Name, todoData.IsDone, todoData.TasksLeft);
            _db.Todos.Add(newTodo);
            return newTodo;
        }

        internal List<Todo> Get()
        {
            return _db.Todos;
        }

        internal Todo GetOne(int todoId)
        {
            Todo todo = _db.Todos.Find(t => t.Id == todoId);
            return todo;
        }
    }
}