namespace QuizAPP.Models.Entities
{
    public record Option
    {
        public Guid Id { get; set; }
        public required string Text { get; set; }

        //Relationship
        public Guid QuestionId { get; set; }

         
    }
}
