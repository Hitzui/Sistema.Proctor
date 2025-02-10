using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.Data;

public class ProyectoProfile: Profile
{
    public ProyectoProfile()
    {
        CreateMap<Proyecto, ProyectoDto>().ReverseMap();
    }
}