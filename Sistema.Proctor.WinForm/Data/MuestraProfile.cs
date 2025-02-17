using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Data;

public class MuestraProfile : Profile
{
    public MuestraProfile()
    {
        CreateMap<Muestra, MuestraDto>().ReverseMap();
    }
}