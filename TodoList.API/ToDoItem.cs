namespace TodoList.API
{

        public class ToDoItem
        {
            public int Id { get; set; }
            public string TaskName { get; set; }
            public DateTime? CompletionDate { get; set; }
            public string?  Description { get; set; }


        public ToDoItem()
        {
            // Set DueDate to be 1 week from now if it's initially null
            if (DueDate == default)
            {
                DueDate = DateTime.Now.AddDays(7);
            }
        }
    }
    

}
