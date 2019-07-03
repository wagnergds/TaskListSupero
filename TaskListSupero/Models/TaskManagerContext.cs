using System.Data.Entity;

namespace TaskListSupero.Models
{
    public class TaskListSuperoContext : DbContext
    {
        public TaskListSuperoContext() : base("TaskListSupero")
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}