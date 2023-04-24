using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace todo_list.Models
{
    public class Todo
    {
        public Todo(string body, int id, string name, bool isDone, int tasksLeft)
        {
            Body = body;
            Name = name;
            IsDone = isDone;
            Id = id;
            TasksLeft = tasksLeft;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public bool IsDone { get; set; }
        public string Name { get; set; }
        [Range(0, 9)]
        public int TasksLeft { get; set; } = 9;

        void done(string todo)
        {
            if (todo == "checked")
            {
                TasksLeft--;
            }
        }
    }
}