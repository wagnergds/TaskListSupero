using System.Collections.Generic;

namespace TaskListSupero.Models
{
    public interface ITaskListSuperoRepository
    {
        IEnumerable<Task> GetAllTasks();

        Task GetTaskById(int id);

        void AddTask(Task task);

        void EditTask(Task task);

        void ChangeStatus(Task task);

        void DeleteTask(Task task);
    }
}
