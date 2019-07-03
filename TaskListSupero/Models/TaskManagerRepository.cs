using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace TaskListSupero.Models
{
    public class TaskListSuperoRepository : ITaskListSuperoRepository
    {
        private TaskListSuperoContext _context;

        public TaskListSuperoRepository(TaskListSuperoContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _context.Tasks.OrderBy(t => t.Status).ThenBy(t => t.DueDate).ToList();
        }

        public Task GetTaskById(int id)
        {
            return _context.Tasks.Find(id);
        }

        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void EditTask(Task task)
        {
            _context.Entry(task).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void ChangeStatus(Task task)
        {
            if (task.Status == false)
            {
                task.Status = true;
            }
            else
            {
                task.Status = false;
            }

            _context.Entry(task).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}