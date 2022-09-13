using AutoMapper;
using JaizBank.Application.JaizBank.ViewModel;
using JaizBankDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Application.JaizBank.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Transactions, TransactionsViewModel>();
        }
    }
}
