using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Interfaces
{
    public interface ITypeService
    {
        void Create(TypeCreateDto typeCreateDto);

        List<Models.Type> GetAll();

        void EditType(Models.Type type);

        void DeleteTypeById(int id);

        Models.Type GetTypeById(int id);
    }
}
