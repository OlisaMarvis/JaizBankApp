using AutoMapper;
using JaizBank.Application.JaizBank.ViewModel;
using JaizBankDomain.Entities;

namespace JaizBank.Application.JaizBank.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TransactionsViewModel, Transactions>();
        }
    }
}
