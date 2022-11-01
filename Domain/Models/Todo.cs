using System.Collections.Generic;

namespace Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public User Owner { get; }
        public string Title { get; }
        public bool isCompleted { get; }

        public Todo(User owner, string title)
        {
            Owner = owner;
            Title = title; 
        }
        
        // public List<Todo> Todos { get; set; }
        

    }
}