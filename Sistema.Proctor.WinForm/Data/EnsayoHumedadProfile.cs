using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Data;

public class EnsayoHumedadProfile : Profile
{
    public EnsayoHumedadProfile()
    {
        CreateMap<EnsayoHumedad, EnsayoHumedadDto>().ReverseMap();
    }
}