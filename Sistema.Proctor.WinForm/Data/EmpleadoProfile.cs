using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.Data;

public class EmpleadoProfile : Profile
{
    public EmpleadoProfile()
    {
        CreateMap<Empleado, EmpleadoDto>().ReverseMap();
    }
}