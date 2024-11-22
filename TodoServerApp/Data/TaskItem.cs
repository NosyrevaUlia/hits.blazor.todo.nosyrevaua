namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
    
}


// завести справочник пользвателя с возможностью создание/изменение/удаление ФИО (слева пользователи в меню)
// модифицировать сущность задачи (исполнитель в задачи(справочник))