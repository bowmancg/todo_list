using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_list.Services
{
    public class TodosService
    {
        
        private readonly TodosRepository _repo;
        public TodosService(TodosRepository repo)
        {
            _repo = repo;
        }

    internal Todo Create(Todo todoData)
    {
        return _repo.Create(todoData);
    }

    internal List<Todo> Get()
    {
        List<Todo> todos = _repo.Get();
        return todos;
    }
    }
}