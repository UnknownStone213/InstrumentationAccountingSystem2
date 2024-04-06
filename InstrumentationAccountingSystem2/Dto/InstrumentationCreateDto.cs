﻿namespace InstrumentationAccountingSystem2.Dto
{
    public class InstrumentationCreateDto
    {
        public int TypeId { get; set; } // тип
        public string? Model { get; set; } // модель
        public string? FactoryNumber { get; set; } // заводской номер
        public int? LocationId { get; set; } // место установки
        public string? MeasurementLimits { get; set; } // пределы измерений
        public int? Frequency { get; set; } // периодичность измерений
        public string? Connection { get; set; } // присоединение к процессу
        public string? Comment { get; set; } // примечание
    }
}
