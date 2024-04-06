using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Interfaces
{
    public interface IVerificationService
    {
        void Create(VerificationCreateDto verificationCreateDto);

        List<Verification> GetAll();

        void EditVerification(Verification verification);

        void DeleteVerificationById(int id);

        Verification GetVerificationById(int id);

        Verification? GetLastVerificationByInstrumentationId(int id);
    }
}
