using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.Data;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, ClienteDto>().ReverseMap();
    }
}