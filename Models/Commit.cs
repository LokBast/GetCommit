namespace URALSIB.Models
{
    public class Commit
    {
        public int Id { get; set; }
        public string Sha { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        // Другие свойства коммита
    }
}
