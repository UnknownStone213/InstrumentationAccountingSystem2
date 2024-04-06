using AutoMapper;
using InstrumentationAccountingSystem2.BusinessLogic.Interfaces;
using InstrumentationAccountingSystem2.Dto;
using InstrumentationAccountingSystem2.Models;

namespace InstrumentationAccountingSystem2.BusinessLogic.Services
{
    public class TypeService : ITypeService
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;

        public TypeService(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext = applicationContext;
            _mapper = mapper;
        }

        public void Create(TypeCreateDto typeCreateDto)
        {
            var type = _mapper.Map<TypeCreateDto, Models.Type>(typeCreateDto);

            _applicationContext.Types.Add(type);
            _applicationContext.SaveChanges();
        }

        public List<Models.Type> GetAll()
        {
            var types = _applicationContext.Types.ToList();

            return types;
        }

        public void EditType(Models.Type type)
        {
            _applicationContext.Types.Update(type);
            _applicationContext.SaveChanges();
        }

        public void DeleteTypeById(int id)
        {
            var type = _applicationContext.Types.FirstOrDefault(u => u.Id == id);

            _applicationContext.Types.Remove(type);
            _applicationContext.SaveChanges();
        }

        public Models.Type GetTypeById(int id)
        {
            var type = _applicationContext.Types.FirstOrDefault(u => u.Id == id);

            return type;
        }
    }
}
