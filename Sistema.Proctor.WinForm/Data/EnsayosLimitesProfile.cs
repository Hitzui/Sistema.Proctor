using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Data;

public class EnsayosLimitesProfile : Profile
{
    public EnsayosLimitesProfile()
    {
        CreateMap<EnsayoLimite, EnsayoLimitesDto>().ReverseMap();
    }
}