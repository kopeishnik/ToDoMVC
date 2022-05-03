namespace ToDoMVC1.Models
{
    public class TaskModel
    {
        //public TaskModel(int id, string name, DateTime deadline, bool isCompleted, int categoryId)
        //{
        //    Id = id;
        //    Name = name;
        //    Deadline = deadline;
        //    IsCompleted = isCompleted;
        //    CategoryId = categoryId;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public int CategoryId { get; set; }

    }
}
