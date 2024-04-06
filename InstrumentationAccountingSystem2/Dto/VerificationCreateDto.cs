namespace InstrumentationAccountingSystem2.Dto
{
    public class VerificationCreateDto
    {
        public DateOnly Date { get; set; } // дата поверки
        public int InstrumentationId { get; set; } // СИ
    }
}
