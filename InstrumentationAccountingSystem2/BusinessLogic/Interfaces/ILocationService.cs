using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Interfaces
{
    public interface ILocationService
    {
        void Create(LocationCreateDto locationCreateDto);

        List<Location> GetAll();

        void EditLocation(Location location);

        void DeleteLocationById(int id);

        Location GetLocationById(int id);
    }
}
