namespace ToDoMVC1.Models
{
    public interface ITasksRepository
    {
        IEnumerable<TaskModel> Tasks { get; }
    }
}
