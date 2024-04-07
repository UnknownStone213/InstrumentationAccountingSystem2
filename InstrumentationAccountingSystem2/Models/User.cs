using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstrumentationAccountingSystem2.Models
{
    public class User : IdentityUser
    {
        public User() { }
        public User(string fname, string lname, string patronymic) { FirstName = fname; LastName = lname; Patronymic = patronymic; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Patronymic { get; set; }
    }
}
