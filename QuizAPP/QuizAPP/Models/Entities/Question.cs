namespace QuizAPP.Models.Entities
{
    public record Question
    {
        public Guid ID { get; set; }
        public required string Text { get; set; }

        //Options
        public required List<Option> Option { get; set; }

        public required Guid CorrectOption {  get; set; }
    }
}
