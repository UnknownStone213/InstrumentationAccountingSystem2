using AutoMapper;
using InstrumentationAccountingSystem2.BusinessLogic.Interfaces;
using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Services
{
    public class InstrumentationService : IInstrumentationService
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;

        public InstrumentationService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public void Create(InstrumentationCreateDto InstrumentationCreateDto)
        {
            var instrumentation = _mapper.Map<InstrumentationCreateDto, Instrumentation>(InstrumentationCreateDto);

            _applicationContext.Instrumentations.Add(instrumentation);
            _applicationContext.SaveChanges();
        }

        public List<Instrumentation> GetAll()
        {
            var Instrumentations = _applicationContext.Instrumentations.ToList();

            return Instrumentations;
        }

        public void DeleteInstrumentationById(int id)
        {
            var instrumentation = _applicationContext.Instrumentations.FirstOrDefault(u => u.Id == id);

            _applicationContext.Instrumentations.Remove(instrumentation);
            _applicationContext.SaveChanges();
        }

        public void Edit(Instrumentation instrumentation)
        {
            _applicationContext.Instrumentations.Update(instrumentation);
            _applicationContext.SaveChanges();
        }

        public Instrumentation GetInstrumentationById(int id)
        {
            var instrumentation = _applicationContext.Instrumentations.FirstOrDefault(u => u.Id == id);

            return instrumentation;
        }
    }
}
