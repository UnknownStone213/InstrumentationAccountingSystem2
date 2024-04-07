using System.ComponentModel.DataAnnotations;

namespace InstrumentationAccountingSystem2.Models
{
    public class Instrumentation
    {
        [Key]
        public int Id { get; set; }
        public int? TypeId { get; set; } // тип
        public Type? Type { get; set; }
        [StringLength(100)]
        public string? Model { get; set; } // модель
        [StringLength(100)]
        public string? FactoryNumber { get; set; } // заводской номер
        public int? LocationId { get; set; } // место установки
        public Location? Location { get; set; }
        [StringLength(100)]
        public string? MeasurementLimits { get; set; } // пределы измерений
        public int? Frequency { get; set; } // периодичность измерений
        [StringLength(100)]
        public string? Connection { get; set; } // присоединение к процессу
        [StringLength(250)]
        public string? Comment { get; set; } // примечание
    }
}
