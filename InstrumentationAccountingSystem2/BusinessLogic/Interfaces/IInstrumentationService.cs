using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Interfaces
{
    public interface IInstrumentationService
    {
        void Create(InstrumentationCreateDto InstrumentationCreateDto);

        List<Instrumentation> GetAll();

        void DeleteInstrumentationById(int id);

        void Edit(Instrumentation Instrumentation);

        Instrumentation GetInstrumentationById(int id);
    }
}
