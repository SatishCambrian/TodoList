namespace TodoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime? CompletionDate { get; set; }   
    }
}
