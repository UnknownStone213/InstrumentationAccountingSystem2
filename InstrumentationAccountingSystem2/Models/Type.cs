using System.ComponentModel.DataAnnotations;

namespace InstrumentationAccountingSystem2.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public ICollection<Instrumentation> Instrumentations { get; } = new List<Instrumentation>();
    }
}
