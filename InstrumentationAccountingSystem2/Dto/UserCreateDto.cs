using System.ComponentModel.DataAnnotations.Schema;

namespace InstrumentationAccountingSystem2.Dto
{
    public class UserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
    }
}
