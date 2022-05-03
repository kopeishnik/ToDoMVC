namespace ToDoMVC1.Models
{
    public class FakeTasksRepository : ITasksRepository
    {
        public IEnumerable<TaskModel> Tasks => new List<TaskModel>
        {
            new TaskModel {Id = 1, Name = "Create Database", IsCompleted = false}
        };
    }
}
