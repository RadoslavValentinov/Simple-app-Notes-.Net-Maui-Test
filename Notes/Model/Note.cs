namespace Notes.Model
{
    public class Note
    {
        public string Filename { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
